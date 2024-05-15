using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_delivery_service_app.src
{
    public class UserData
    {
        public int id;
        public string email;
        public string password;
        public string fullName;
        public string phone;
        public string role;

        public UserData(int id, string email, string password, string fullName, string phone, string role)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.fullName = fullName;
            this.phone = phone;
            this.role = role;
        }

        public Control ToPanel(int width, int height)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Size = new Size(width, height);
            panel.WrapContents = false;
            panel.FlowDirection = FlowDirection.TopDown;

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Text = $"ID: {id}";

            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Text = $"Email: {email}";

            Label label3 = new Label();
            label3.AutoSize = true;
            label3.Text = $"Пароль: {password}";

            Label label4 = new Label();
            label4 .AutoSize = true;
            label4.Text = $"ПІБ: {fullName}";

            Label label5 = new Label();
            label5 .AutoSize = true;
            label5.Text = $"Телефон: {phone}";

            panel.Controls.Add(label1);
            panel.Controls.Add(label2);
            panel.Controls.Add(label3);
            panel.Controls.Add(label4);
            panel.Controls.Add(label5);

            if (role == "Courier")
            {
                // Робота з БД
                DatabaseAPI.Connect();

                Transport transport = DatabaseAPI.GetTransport(id);

                DatabaseAPI.CloseConnection();

                Label label6 = new Label();
                label6.AutoSize = true;
                label6.Text = $"Тип транспорту: {transport.type ?? "Не визначено" }";

                Label label7 = new Label();
                label7.AutoSize = true;
                label7.Text = $"Номер транспорту: {transport.number ?? "Не визначено"}";

                panel.Controls.Add(label6);
                panel.Controls.Add(label7);
            }

            Button button = new Button();
            button.AutoSize = true;
            button.BackColor = Color.MediumSeaGreen;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.Text = "Переглянути історію";

            panel.Controls.Add(button);

            return panel;
        }
    }
}
