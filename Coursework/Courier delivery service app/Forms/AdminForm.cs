using Courier_delivery_service_app.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_delivery_service_app.Forms
{
    public partial class AdminForm : Form
    {
        UserData user;

        private string[] transportTypes =
        {
            "Велосипед",
            "Скутер",
            "Легковий автомобіль"
        };

        public AdminForm(UserData user)
        {
            this.user = user;

            InitializeComponent();

            accountNameGreetingLabel.Text = $"Вітаємо, {this.user.fullName}!";

            // Заповнюємо "комбо-бокс" з типами транспорту
            courierTransportTypeInputBox.Items.AddRange(transportTypes);
            courierTransportTypeInputBox.SelectedIndex = 0;

            UpdateClients();
            UpdateCouriers();
            UpdateParcels();
        }

        private void addCourierButton_Click(object sender, EventArgs e)
        {
            string email = courierEmailInputBox.Text;
            string password = courierPasswordInputBox.Text;
            string fullName = courierFullNameInputBox.Text;
            string phone = courierPhoneInputBox.Text;
            string transportType = (string)courierTransportTypeInputBox.SelectedItem!;
            string transportNumber = courierTransportPlateNumInputBox.Text;

            AddCourier(email, password, fullName, phone, transportType, transportNumber);

            ClearPanel(couriersPanel);

            UpdateCouriers();
        }

        private void AddCourier(string email, string password, string fullName, string phone, string transportType, string? transportNumber)
        {
            try
            {
                DatabaseAPI.Connect();

                if (!Validator.IsEmail(email))
                {
                    throw new ArgumentException("Введений email не відповідає формату.");
                }

                if (!Validator.IsPhone(phone))
                {
                    throw new ArgumentException("Введений телефон не відповідає формату.");
                }

                int count = DatabaseAPI.CountPersonsWithEmailAndPhone(email, phone);

                if (count > 0)
                {
                    throw new ArgumentException("Введений email або телефон вже зайняті.");
                }

                if (transportType == "Велосипед")
                {
                    if (transportNumber.Length > 0)
                    {
                        throw new ArgumentException("Номерний знак не може бути присвоєний велосипеду.");
                    }
                    else
                    {
                        transportNumber = null;
                    }
                }
                else
                {
                    if (!Validator.IsTransportNumber(transportNumber))
                    {
                        throw new ArgumentException("Введений номерний знак не відповідає формату.");
                    }
                }

                // Робота з MS SQL Server (id для кур'єра)

                DatabaseAPI.InsertPerson(email, password, fullName, phone, "Courier");

                int id = DatabaseAPI.GetPerson(email, password).id;

                // Робота з MS SQL Server (запис транспорту в БД)
                DatabaseAPI.InsertTransport(id, transportType, transportNumber);

                DatabaseAPI.CloseConnection();
            }
            catch (ArgumentException ex)
            {
                statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): {ex.Message}";

                return;
            }

            statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): Успішно додано кур'єра!";
        }

        private void manualQueryModeButton_Click(object sender, EventArgs e)
        {
            var form = new QueriesForm();

            form.Show();
        }

        private void updateClientsButton_Click(object sender, EventArgs e)
        {
            ClearPanel(clientsPanel);

            UpdateClients();
        }

        private void UpdateClients()
        {
            DatabaseAPI.Connect();

            clientsPanel.SuspendLayout();

            List<UserData> clients = DatabaseAPI.GetPersonsByRole("Client");

            foreach (UserData client in clients)
            {
                var panel = client.ToPanel(clientsPanel.Width, (int)(clientsPanel.Height * 0.5));

                // Останній Control - це кнопка
                panel.Controls[panel.Controls.Count - 1].Click += (sender, e) => ClientViewHistoryButton_click(sender, e, client.id);

                clientsPanel.Controls.Add(panel);
            }

            clientsPanel.ResumeLayout(true);

            DatabaseAPI.CloseConnection();
        }

        private void ClientViewHistoryButton_click(object? sender, EventArgs e, int clientId)
        {
            ClearPanel(parcelsPanel);

            DatabaseAPI.Connect();

            parcelsPanel.SuspendLayout();

            List<Parcel> parcels = DatabaseAPI.GetClientParcels(clientId);

            foreach (Parcel parcel in parcels)
            {
                var panel = parcel.ToPanel(parcelsPanel.Width, parcelsPanel.Height, "Admin");

                parcelsPanel.Controls.Add(panel);
            }

            parcelsPanel.ResumeLayout(true);

            DatabaseAPI.CloseConnection();

            statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): Обрано перегляд історії посилок клієнта #{clientId}";
        }

        private void ClearPanel(Control panel)
        {
            foreach (Control control in panel.Controls)
            {
                control.Dispose();
            }

            panel.Controls.Clear();
        }

        private void updateCouriersButton_Click(object sender, EventArgs e)
        {
            ClearPanel(couriersPanel);

            UpdateCouriers();
        }

        private void UpdateCouriers()
        {
            DatabaseAPI.Connect();

            List<UserData> couriers = DatabaseAPI.GetPersonsByRole("Courier");

            foreach (UserData courier in couriers)
            {
                var panel = courier.ToPanel(clientsPanel.Width, (int)(clientsPanel.Height * 0.5));

                // Останній Control - це кнопка
                panel.Controls[panel.Controls.Count - 1].Click += (sender, e) => CourierViewHistoryButton_click(sender, e, courier.id);

                couriersPanel.Controls.Add(panel);
            }

            DatabaseAPI.CloseConnection();

        }

        private void CourierViewHistoryButton_click(object sender, EventArgs e, int id)
        {
            ClearPanel(parcelsPanel);

            DatabaseAPI.Connect();

            parcelsPanel.SuspendLayout();

            List<Parcel> parcels = DatabaseAPI.GetCourierParcels(id);

            foreach (Parcel parcel in parcels)
            {
                var panel = parcel.ToPanel(parcelsPanel.Width, parcelsPanel.Height, "Admin");

                parcelsPanel.Controls.Add(panel);
            }

            parcelsPanel.ResumeLayout(true);

            DatabaseAPI.CloseConnection();

            statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): Обрано перегляд історії посилок кур'єра #{id}";
        }

        private void updateParcelsButton_Click(object sender, EventArgs e)
        {
            ClearPanel(parcelsPanel);

            UpdateParcels();
        }

        private void UpdateParcels()
        {
            DatabaseAPI.Connect();

            List<Parcel> parcels = DatabaseAPI.GetAllParcels();

            foreach (Parcel parcel in parcels)
            {
                var panel = parcel.ToPanel(clientsPanel.Width, clientsPanel.Height, "Admin");

                parcelsPanel.Controls.Add(panel);
            }

            DatabaseAPI.CloseConnection();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm(this);

            form.Show();
        }

        public void FilterClients(string name, string surname)
        {
            DatabaseAPI.Connect();

            List<UserData> clientsFiltered = DatabaseAPI.GetPersonsByRole("Client");

            DatabaseAPI.CloseConnection();

            HashSet<int> indexesToRemove = new HashSet<int>();

            if (name != string.Empty)
            {
                for (int i = 0; i < clientsFiltered.Count; i++)
                {
                    var client = clientsFiltered[i];
                    string clientName = client.fullName.Split(" ")[1];

                    if (clientName != name) indexesToRemove.Add(i);
                }
            }

            if (surname != string.Empty)
            {
                for (int i = 0; i < clientsFiltered.Count; i++)
                {
                    var client = clientsFiltered[i];
                    string clientSurname = client.fullName.Split(" ")[0];

                    if (clientSurname != surname) indexesToRemove.Add(i);
                }
            }

            ClearPanel(clientsPanel);

            for (int i = 0; i < clientsFiltered.Count; i++)
            {
                if (!indexesToRemove.Contains(i))
                    clientsPanel.Controls.Add(clientsFiltered[i].ToPanel(clientsPanel.Width, (int)(clientsPanel.Height * 0.5)));
            }
        }

        public void FilterCouriers(string name, string surname, string transportNumber)
        {
            DatabaseAPI.Connect();

            List<(UserData, Transport)> couriersAndTransport = DatabaseAPI.GetAllCourierAndTransport();

            DatabaseAPI.CloseConnection();

            HashSet<int> indexesToRemove = new HashSet<int>();

            if (name != string.Empty)
            {
                for (int i = 0; i < couriersAndTransport.Count; i++)
                {
                    var courier = couriersAndTransport[i].Item1;
                    string courierName = courier.fullName.Split(" ")[1];

                    if (courierName != name) indexesToRemove.Add(i);
                }
            }

            if (surname != string.Empty)
            {
                for (int i = 0; i < couriersAndTransport.Count; i++)
                {
                    var courier = couriersAndTransport[i].Item1;
                    string courierSurname = courier.fullName.Split(" ")[0];

                    if (courierSurname != surname) indexesToRemove.Add(i);
                }
            }

            if (transportNumber != string.Empty)
            {
                for (int i = 0; i < couriersAndTransport.Count; i++)
                {
                    var transport = couriersAndTransport[i].Item2;

                    if (transport.number != transportNumber) indexesToRemove.Add(i);
                }
            }

            ClearPanel(couriersPanel);

            for (int i = 0; i < couriersAndTransport.Count; i++)
            {
                if (!indexesToRemove.Contains(i))
                    couriersPanel.Controls.Add(couriersAndTransport[i].Item1.ToPanel(couriersPanel.Width, (int)(couriersPanel.Height * 0.5)));
            }
        }

        public void FilterParcels(DateTime acceptDateTime, DateTime sendingDateTime, DateTime arrivalDateTime)
        {
            DatabaseAPI.Connect();

            List<Parcel> parcels = DatabaseAPI.GetAllParcels();

            DatabaseAPI.CloseConnection();

            HashSet<int> indexesToRemove = new HashSet<int>();

            for (int i = 0; i < parcels.Count; i++)
            {
                var parcel = parcels[i];

                if (parcel.acceptDateTime != null && !Equals(parcel.acceptDateTime.Value.Date, acceptDateTime.Date))
                    indexesToRemove.Add(i);

                if (parcel.sendingDateTime != null && !Equals(parcel.sendingDateTime.Value.Date, sendingDateTime.Date))
                    indexesToRemove.Add(i);

                if (parcel.arrivalDateTime != null && !Equals(parcel.arrivalDateTime.Value.Date, arrivalDateTime.Date))
                    indexesToRemove.Add(i);
            }

            ClearPanel(parcelsPanel);

            for (int i = 0; i < parcels.Count; i++)
            {
                if (!indexesToRemove.Contains(i))
                    parcelsPanel.Controls.Add(parcels[i].ToPanel(parcelsPanel.Width, parcelsPanel.Height, "Admin"));
            }
        }

        private void courierStatsButton_Click(object sender, EventArgs e)
        {
            CourierStats courierStats = new CourierStats();

            courierStats.Show();
        }
    }
}
