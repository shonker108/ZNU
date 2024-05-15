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

namespace Courier_delivery_service_app.Forms
{
    public partial class ClientForm : Form
    {
        private UserData user;
        public ClientForm(UserData user)
        {
            this.user = user;

            InitializeComponent();

            accountNameGreetingLabel.Text = $"Вітаємо, {this.user.fullName}!";

            UpdateParcelList();
        }

        private void calculatePriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();

                if (!float.TryParse(weightInputBox.Text, out float weight))
                {
                    throw new ArgumentException("Вага введена некоректно!");
                }

                float price = weight * 10 * ((float)random.NextDouble() + 1);

                priceOutputBox.Text = ((int)price).ToString();
            }
            catch (ArgumentException ex)
            {
                statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): {ex.Message}";
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Адреса відправки
                string sendingAddrRegion = sendingAddrRegionInputBox.Text;
                string sendingAddrCity = sendingAddrCityInputBox.Text;
                string sendingAddrStreet = sendingAddrStreetInputBox.Text;

                if (!int.TryParse(sendingAddrHouseInputBox.Text, out int sendingAddrHouse))
                {
                    throw new ArgumentException("Адреса відправки; Номер дому введено некоректно.");
                }

                int? sendingAddrApartment = null;

                if (sendingAddrApartmentInputBox.Text.Length > 0)
                {
                    try
                    {
                        sendingAddrApartment = int.Parse(sendingAddrApartmentInputBox.Text);
                    }
                    catch (FormatException ex)
                    {
                        throw new ArgumentException("Адреса відправки; Квартира введена некоректно.");
                    }
                }

                Address sendingAddress = new Address(
                   sendingAddrRegion,
                   sendingAddrCity,
                   sendingAddrStreet,
                   sendingAddrHouse,
                   sendingAddrApartment
                );

                // Адреса прибуття
                string arrivalAddrRegion = arrivalAddrRegionInputBox.Text;
                string arrivalAddrCity = arrivalAddrCityInputBox.Text;
                string arrivalAddrStreet = arrivalAddrStreetInputBox.Text;

                if (!int.TryParse(arrivalAddrHouseInputBox.Text, out int arrivalAddrHouse))
                {
                    throw new ArgumentException("Адреса прибуття; Номер дому введено некоректно.");
                }

                int? arrivalAddrApartment = null;

                if (arrivalAddrApartmentInputBox.Text.Length > 0)
                {
                    try
                    {
                        arrivalAddrApartment = int.Parse(arrivalAddrApartmentInputBox.Text);
                    }
                    catch (FormatException ex)
                    {
                        throw new ArgumentException("Адреса прибуття; Квартира введена некоректно.");
                    }
                }

                Address arrivalAddress = new Address(
                   arrivalAddrRegion,
                   arrivalAddrCity,
                   arrivalAddrStreet,
                   arrivalAddrHouse,
                   arrivalAddrApartment
                );

                // Отримувач
                string recieverFullName = recieverFullNameInputBox.Text;

                string recieverPhone = recieverPhoneInputBox.Text;

                if (!Validator.IsPhone(recieverPhone))
                {
                    throw new ArgumentException("Телефон отримувача введено некоректно.");
                }

                // Вага
                if (!float.TryParse(weightInputBox.Text, out float weight))
                {
                    throw new ArgumentException("Вага посилки введена некоректно.");
                }

                // Ціна
                if (!int.TryParse(priceOutputBox.Text, out int price))
                {
                    throw new ArgumentException("Будь-ласка, розрахуйте ціну відправки посилки. Потім можете натискати на цю кнопку.");
                }

                CreateParsel(user, sendingAddress, arrivalAddress, recieverFullName, recieverPhone, weight, price);

                UpdateParcelList();
            }
            catch (ArgumentException ex)
            {
                statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): {ex.Message}";

                return;
            }

            statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): Успішно створено посилку!";
        }

        private void CreateParsel(UserData sender, Address sendingAddress, Address arrivalAddress, string recieverFullName, string recieverPhone, float parcelWeight, int deliveryPrice)
        {
            // Робота з БД
            DatabaseAPI.Connect();

            ParcelStatus status = ParcelStatus.Registered;
            DateTime statusDateTime = DateTime.Now;

            DatabaseAPI.InsertParcel(sender.id, null, ParcelStatus.Registered, statusDateTime, sendingAddress, arrivalAddress, recieverFullName, recieverPhone, null, null, null, parcelWeight, deliveryPrice);

            int id = DatabaseAPI.GetLastIDFromTable("Parcel");

            DatabaseAPI.CloseConnection();

            Parcel parcel = new Parcel(id, sender.id, null, (int)ParcelStatus.Registered, statusDateTime, sendingAddress, arrivalAddress, recieverFullName, recieverPhone, null, null, null, parcelWeight, deliveryPrice);

            parcelsPanel.Controls.Add(parcel.ToPanel(parcelsPanel.Width, parcelsPanel.Height, user.role));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateParcelList();
        }

        private void UpdateParcelList()
        {
            DatabaseAPI.Connect();

            ClearParcelList();

            List<Parcel> clientParcels = DatabaseAPI.GetClientParcels(user.id);

            foreach (Parcel parcel in clientParcels)
            {
                var panel = parcel.ToPanel(parcelsPanel.Width, parcelsPanel.Height, user.role);

                panel.Controls[panel.Controls.Count - 1].Click += (sender, e) => ClientCancelButton_click(sender, e, parcel.id);
                
                parcelsPanel.Controls.Add(panel);
            }

            DatabaseAPI.CloseConnection();
        }

        private void ClientCancelButton_click(object? sender, EventArgs e, int parcelId)
        {
            DatabaseAPI.Connect();

            DatabaseAPI.ChangeParcelStatus(parcelId, ParcelStatus.Canceled);

            DatabaseAPI.CloseConnection();

            statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): Посилку успішно скасовано!";

            UpdateParcelList();
        }

        private void ClearParcelList()
        {
            foreach (Control control in parcelsPanel.Controls)
            {
                control.Dispose();
            }

            parcelsPanel.Controls.Clear();
        }
    }
}
