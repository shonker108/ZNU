using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Courier_delivery_service_app.src
{
    public enum ParcelStatus
    {
        Registered,
        WaitingForPickUp,
        InTransit,
        Completed,
        Canceled
    }
    public class Parcel
    {
        public int id;
        public int clientId;
        public int? courierId;              // Нульове, бо кур'єр може приєднатися не зразу
        public int statusId;
        public DateTime statusDateTime;
        public Address sendingAddress;
        public Address arrivalAddress;
        public string recieverFullName;
        public string recieverPhone;
        public DateTime? acceptDateTime;    // Нульове, бо кур'єр може приєднатися не зразу
        public DateTime? sendingDateTime;   // Нульове, бо посилка буде прийнята лише після прийняття кур'єром
        public DateTime? arrivalDateTime;   // Нульове, бо посилка не може прибути відразу у вказане місце
        public float weight;
        public int price;

        public Parcel(int id, int clientId, int? courierId, int statusId, DateTime statusDateTime, Address sendingAddress, Address arrivalAddress, string recieverFullName, string recieverPhone, DateTime? acceptDateTime, DateTime? sendingDateTime, DateTime? arrivalDateTime, float weight, int price)
        {
            this.id = id;
            this.clientId = clientId;
            this.courierId = courierId;
            this.statusId = statusId;
            this.statusDateTime = statusDateTime;
            this.sendingAddress = sendingAddress;
            this.arrivalAddress = arrivalAddress;
            this.recieverFullName = recieverFullName;
            this.recieverPhone = recieverPhone;
            this.acceptDateTime = acceptDateTime;
            this.sendingDateTime = sendingDateTime;
            this.arrivalDateTime = arrivalDateTime;
            this.weight = weight;
            this.price = price;
        }

        // Функція для форматування класу до об'єкту Control, щоб його можна було показувати
        // у формах. Наповнення буде дещо різним в залежності від ролі користувача
        public Control ToPanel(int width, int height, string role)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Size = new Size(width, (int)(height * 0.75));
            panel.WrapContents = false;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.SuspendLayout();

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Text = $"ID: {id}";

            Label label2 = new Label();
            label2.AutoSize = true;
            
            if (role == "Courier")
            {
                label2.Text = $"Клієнт: {DatabaseAPI.GetPersonFullName(clientId)}\nТелефон: {DatabaseAPI.GetPersonPhone(clientId)}";
            }
            else if (role == "Client")
            {
                label2.Text = $"Кур'єр: {(courierId is null ? "Не призначений" : DatabaseAPI.GetPersonFullName((int)courierId))}";
            }
            else if (role == "Admin")
            {
                label2.Text = $"ПІБ клієнта: {DatabaseAPI.GetPersonFullName(clientId)} (ID: {clientId})\nПІБ кур'єра: {(courierId is null ? "Не призначений" : $"{DatabaseAPI.GetPersonFullName((int)courierId)} (ID: {courierId})")}";
            }

            Label label3 = new Label();
            label3.AutoSize = true;
            label3.Text = $"Статус: {Parcel.StatusToString((ParcelStatus)statusId)}";

            Label label4 = new Label();
            label4.AutoSize = true;
            label4.Text = $"Дата встановлення статусу: {statusDateTime}";

            Label label5 = new Label();
            label5.AutoSize = true;
            label5.Text = $"Адреса відправки: {sendingAddress}";

            Label label6 = new Label();
            label6.AutoSize = true;
            label6.Text = $"Адреса прибуття: {arrivalAddress}";

            Label label7 = new Label();
            label7.AutoSize = true;
            label7.Text = $"ПІБ отримувача: {recieverFullName}";

            Label label8 = new Label();
            label8.AutoSize = true;
            label8.Text = $"Телефон отримувача: {recieverPhone}";

            Label label9 = new Label();
            label9.AutoSize = true;
            label9.Text = $"Дата прийняття: {(acceptDateTime is null ? "Не визначена" : acceptDateTime)}";

            Label label10 = new Label();
            label10.AutoSize = true;
            label10.Text = $"Дата відправки: {(sendingDateTime is null ? "Не визначена" : sendingDateTime)}";

            Label label11 = new Label();
            label11.AutoSize = true;
            label11.Text = $"Дата прибуття: {(arrivalDateTime is null ? "Не визначена" : arrivalDateTime)}";

            Label label12 = new Label();
            label12.AutoSize = true;
            label12.Text = $"Вага (кг): {weight}";

            Label label13 = new Label();
            label13.AutoSize = true;
            label13.Text = $"Ціна: {price}";

            panel.Controls.Add(label1);
            panel.Controls.Add(label2);
            panel.Controls.Add(label3);
            panel.Controls.Add(label4);
            panel.Controls.Add(label5);
            panel.Controls.Add(label6);
            panel.Controls.Add(label7);
            panel.Controls.Add(label8);
            panel.Controls.Add(label9);
            panel.Controls.Add(label10);
            panel.Controls.Add(label11);
            panel.Controls.Add(label12);
            panel.Controls.Add(label13);

            Button button = new Button();
            button.AutoSize = true;
            button.BackColor = Color.MediumSeaGreen;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;

            if (role == "Client")
            {
                button.Text = "Скасувати";
            }
            else if (role == "Courier")
            {
                if ((ParcelStatus)statusId == ParcelStatus.Registered)
                {
                    button.Text = "Прийняти";
                }
                else
                {
                    button.Text = "Відмовитися";
                }
            }
            else if (role == "Admin")
            {
                button.Text = "Видалити";

                button.Click += AdminDeleteButton_click;
            }

            Button button1 = null;

            if (role == "Courier" && ((ParcelStatus)statusId == ParcelStatus.WaitingForPickUp ||
                (ParcelStatus)statusId == ParcelStatus.InTransit))
            {
                button1 = new Button();
                button1.AutoSize = true;
                button1.BackColor = Color.MediumSeaGreen;
                button1.ForeColor = Color.White;
                button1.FlatStyle = FlatStyle.Flat;

                if ((ParcelStatus)statusId == ParcelStatus.WaitingForPickUp)
                {
                    button1.Text = "Забрати посилку";
                }
                else if ((ParcelStatus)statusId == ParcelStatus.InTransit)
                {
                    button1.Text = "Посилка доставлена";
                }
            }

            // Якщо посилка доставлена, то кнопки "Скасувати" та інших кнопок немає
            if (!((ParcelStatus)statusId == ParcelStatus.Completed))
            {
                panel.Controls.Add(button);

                if (button1 is not null)
                {
                    panel.Controls.Add(button1);
                }
            }

            panel.ResumeLayout(true);

            return panel;
        }

        private void CourierAcceptButton_click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AdminDeleteButton_click(object? sender, EventArgs e)
        {
            DatabaseAPI.Connect();

            DatabaseAPI.DeleteParcel(id);

            DatabaseAPI.CloseConnection();
        }


        private static string StatusToString(ParcelStatus status)
        {
            switch (status)
            {
                case ParcelStatus.Registered:
                    return "Зареєстровано";

                case ParcelStatus.WaitingForPickUp:
                    return "В очікуванні кур'єра";

                case ParcelStatus.InTransit:
                    return "В дорозі";

                case ParcelStatus.Completed:
                    return "Доставлено";

                case ParcelStatus.Canceled:
                    return "Скасовано відправником";

                default:
                    return "Невідомий статус";
            }
        }

    }
}
