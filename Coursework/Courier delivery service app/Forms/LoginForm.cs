using Courier_delivery_service_app.src;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_delivery_service_app.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            
        }


        // Обробка посилання "Вже зареєстрований" при реєстрації
        private void alreadyRegisteredLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationGroupBox.Hide();

            loginGroupBox.Show();
        }

        // Обробка посилання "Не зареєстрований" при вході
        private void hasntRegisteredLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginGroupBox.Hide();

            registrationGroupBox.Show();
        }

        // Обробка кнопки "ОК" при реєстрації
        private void regAcceptButton_Click(object sender, EventArgs e)
        {
            string email = regEmailInputBox.Text;
            string password = regPasswordInputBox.Text;
            string passwordConfirm = regPasswordConfirmationInputBox.Text;
            string fullName = regFullNameInputBox.Text;
            string phone = regPhoneInputBox.Text;

            Register(email, password, passwordConfirm, fullName, phone);
        }

        // Обробка кнопки "ОК" при вході
        private void loginAcceptButton_Click(object sender, EventArgs e)
        {
            string email = loginEmailBox.Text;
            string password = loginPasswordBox.Text;

            bool success = Login(email, password);

            if (success)
            {
                this.Close();
            }
        }

        public bool Register(string email, string password, string passwordConfirm, string fullName, string phone)
        {
            try
            {
                if (!Validator.IsEmail(email))
                {
                    throw new ArgumentException("Введений email не відповідає формату.");
                }

                if (password != passwordConfirm)
                {
                    throw new ArgumentException("Пароль та пароль для підтвердження не співпадають.");
                }

                if (!Validator.IsPhone(phone))
                {
                    throw new ArgumentException("Введений телефон не є дійсним.");
                }

                // При реєстрації роль має бути лише "клієнтом"
                const string role = "Client";

                // Тут має бути використання MS SQL Server

                DatabaseAPI.Connect();

                // Перевірка на наявність пошти в базі даних та телефону

                int count = DatabaseAPI.CountPersonsWithEmailAndPhone(email, phone);

                if (count > 0)
                {
                    throw new ArgumentException("Введений email або телефон вже зайняті.");
                }

                // Якщо немає такого користувача, то вставляємо його
                DatabaseAPI.InsertPerson(email, password, fullName, phone, role);

                int id = DatabaseAPI.GetPerson(email, password).id;

                DatabaseAPI.CloseConnection();

                UserData user = new UserData(id, email, password, fullName, phone, role);

                LoadClientForm(user);
            }
            catch (ArgumentException ex)
            {
                DatabaseAPI.CloseConnection();

                statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): {ex.Message}";

                return false;
            }

            statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): Успішно зареєстровано користувача!";

            return true;
        }

        public bool Login(string email, string password)
        {
            try
            {
                if (!Validator.IsEmail(email))
                {
                    throw new ArgumentException("Введений email не відповідає формату.");
                }

                // Тут має бути використання MS SQL Server

                DatabaseAPI.Connect();

                UserData user = DatabaseAPI.GetPerson(email, password);

                DatabaseAPI.CloseConnection();
                
                if (user.role == "Client")
                {
                    LoadClientForm(user);
                }
                else if (user.role == "Courier")
                {
                    LoadCourierForm(user);
                }
                else if (user.role == "Admin")
                {
                    LoadAdministratorForm(user);
                }

            }
            catch (ArgumentException ex)
            {
                DatabaseAPI.CloseConnection();

                statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): {ex.Message}";

                return false;
            }

            statusStripLabel.Text = string.Empty;
            return true;
        }

        private void LoadAdministratorForm(UserData user)
        {
            var form = new AdminForm(user);

            this.Hide();

            form.ShowDialog();

            this.Close();
        }

        private void LoadCourierForm(UserData user)
        {
            var form = new CourierForm(user);

            this.Hide();

            form.ShowDialog();

            this.Close();
        }

        private void LoadClientForm(UserData user)
        {
            var form = new ClientForm(user);

            this.Hide();

            form.ShowDialog();

            this.Close();
        }

    }


}
