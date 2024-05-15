using Courier_delivery_service_app.Forms;
using Courier_delivery_service_app.src;
using Google.Cloud.SecretManager.V1;
using System.Data.SqlClient;

namespace Courier_delivery_service_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Ініціалізуємо доступ до БД
            const string connectionString = "Data Source=DESKTOP-43DSS3O\\SQLEXPRESS;Initial Catalog=deliveries;Integrated Security=SSPI;";

            DatabaseAPI.connectionString = NewSqlServerTCPConnectionString().ConnectionString;

            Application.Run(new LoginForm());
        }

        public static SqlConnectionStringBuilder NewSqlServerTCPConnectionString()
        {
            var connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = "34.88.102.44",
                UserID = "sqlserver", 
                Password = "1234567890",
                InitialCatalog = "delivery",
                Encrypt = false,
            };
           
            connectionString.Pooling = true;
            
            return connectionString;
        }

    }
}