using Courier_delivery_service_app.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Courier_delivery_service_app.Forms
{
    public partial class CourierForm : Form
    {
        private UserData user;
        public CourierForm(UserData user)
        {
            this.user = user;

            InitializeComponent();

            accountNameGreetingLabel.Text = $"Вітаємо, {this.user.fullName}!";

            UpdateAcceptedParcels();
            UpdateAvailibleParcels();
        }

        private void updateAvailibleParcelsButton_Click(object sender, EventArgs e)
        {
            ClearPanel(availibleParcelsPanel);

            UpdateAvailibleParcels();
        }

        private void UpdateAvailibleParcels()
        {
            DatabaseAPI.Connect();

            List<Parcel> parcels = DatabaseAPI.GetAvailibleParcels();

            foreach (Parcel parcel in parcels)
            {
                var panel = parcel.ToPanel(availibleParcelsPanel.Width, availibleParcelsPanel.Height, user.role);

                // Кнопка діє по різному в залежності від статусу посилки
                panel.Controls[panel.Controls.Count - 1].Click +=
                    ((ParcelStatus)parcel.statusId == ParcelStatus.Registered ?
                    (sender, e) => CourierAcceptButton_click(sender, e, parcel.id) :
                    (sender, e) => CourierCancelButton_click(sender, e, parcel.id));

                availibleParcelsPanel.Controls.Add(panel);
            }

            DatabaseAPI.CloseConnection();
        }

        private void CourierAcceptButton_click(object? sender, EventArgs e, int parcelId)
        {
            DatabaseAPI.Connect();

            DatabaseAPI.ChangeParcelCourier(parcelId, user.id);
            DatabaseAPI.ChangeParcelStatus(parcelId, ParcelStatus.WaitingForPickUp);
            DatabaseAPI.ChangeParcelDateTime(parcelId, "acceptDateTime", DateTime.Now);

            DatabaseAPI.CloseConnection();

            ClearPanel(acceptedParcelsPanel);
            UpdateAcceptedParcels();
            ClearPanel(availibleParcelsPanel);
            UpdateAvailibleParcels();
        }

        private void UpdateAcceptedParcels()
        {
            DatabaseAPI.Connect();

            List<Parcel> parcels = DatabaseAPI.GetCourierParcels(user.id, true);

            foreach (Parcel parcel in parcels)
            {
                var panel = parcel.ToPanel(acceptedParcelsPanel.Width, (int)(acceptedParcelsPanel.Height * 1.5), user.role);

                // Кнопка "Відмовитися"
                // Кнопка діє по різному в залежності від статусу посилки
                panel.Controls[panel.Controls.Count - 2].Click +=
                    ((ParcelStatus)parcel.statusId == ParcelStatus.Registered ?
                    (sender, e) => CourierAcceptButton_click(sender, e, parcel.id) :
                    (sender, e) => CourierCancelButton_click(sender, e, parcel.id));

                // Кнопка, яка спочатку являється з текстом "Забрати", а потім
                // з "Доставлено"
                panel.Controls[panel.Controls.Count - 1].Click +=
                    ((ParcelStatus)parcel.statusId == ParcelStatus.WaitingForPickUp ?
                    (sender, e) => CourierPickedUpButton_click(sender, e, parcel.id) :
                    (sender, e) => CourierDeliveredButton_click(sender, e, parcel.id));

                acceptedParcelsPanel.Controls.Add(panel);
            }

            DatabaseAPI.CloseConnection();
        }

        private void CourierCancelButton_click(object? sender, EventArgs e, int parcelId)
        {
            DatabaseAPI.Connect();

            DatabaseAPI.ChangeParcelCourier(parcelId, null);
            DatabaseAPI.ChangeParcelStatus(parcelId, ParcelStatus.Registered);
            DatabaseAPI.ChangeParcelDateTime(parcelId, "acceptDateTime", null);

            DatabaseAPI.CloseConnection();

            ClearPanel(acceptedParcelsPanel);
            UpdateAcceptedParcels();
            ClearPanel(availibleParcelsPanel);
            UpdateAvailibleParcels();
        }

        private void CourierPickedUpButton_click(object? sender, EventArgs e, int parcelId)
        {
            DatabaseAPI.Connect();

            DatabaseAPI.ChangeParcelStatus(parcelId, ParcelStatus.InTransit);
            DatabaseAPI.ChangeParcelDateTime(parcelId, "sendingDateTime", DateTime.Now);

            DatabaseAPI.CloseConnection();

            ClearPanel(acceptedParcelsPanel);
            UpdateAcceptedParcels();
        }

        private void CourierDeliveredButton_click(object? sender, EventArgs e, int parcelId)
        {
            DatabaseAPI.Connect();

            DatabaseAPI.ChangeParcelStatus(parcelId, ParcelStatus.Completed);
            DatabaseAPI.ChangeParcelDateTime(parcelId, "arrivalDateTime", DateTime.Now);

            DatabaseAPI.CloseConnection();

            ClearPanel(acceptedParcelsPanel);
            UpdateAcceptedParcels();
        }

        private void ClearPanel(Control panel)
        {
            foreach (Control control in panel.Controls)
            {
                control.Dispose();
            }

            panel.Controls.Clear();
        }

        private void updateAcceptedParcelsButton_Click(object sender, EventArgs e)
        {
            ClearPanel(acceptedParcelsPanel);

            UpdateAcceptedParcels();
        }
    }
}
