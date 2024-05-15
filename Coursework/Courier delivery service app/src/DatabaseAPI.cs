using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Courier_delivery_service_app.src
{
    public static class DatabaseAPI
    {
        public static SqlConnection connection;
        public static string? connectionString;
        public static void Connect()
        {
            if (connectionString == null)
            {
                throw new Exception("Connection string is null! Cannot connect to the database.");
            }

            connection = new SqlConnection(connectionString);

            connection.Open();
        }

        public static void InsertPerson(string email, string password, string fullName, string phone, string role)
        {
            string query = "INSERT INTO Person (Email, Password, FullName, Phone, Role)";
            query += " VALUES (@email, @password, @fullName, @phone, @role)";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("password", password);
            command.Parameters.Add(new SqlParameter("@fullName", SqlDbType.NVarChar, 100)).Value = fullName;
            command.Parameters.AddWithValue("phone", phone);
            command.Parameters.AddWithValue("role", role);

            command.ExecuteNonQuery();
        }

        public static void InsertParcel(int clientId, int? courierId, ParcelStatus status, DateTime statusDateTime, Address sendingAddress, Address arrivalAddress, string recieverFullName, string recieverPhone, DateTime? acceptDateTime, DateTime? sendingDateTime, DateTime? arrivalDateTime, float parcelWeight, int deliveryPrice)
        {
            string query = "INSERT INTO Parcel (ClientID, CourierID, StatusID, StatusDateTime, SendingAddress, ArrivalAddress, RecieverFullName, RecieverPhone, AcceptDateTime, SendingDateTime, ArrivalDateTime, Weight, DeliveryPrice)";
            query += "VALUES (@ClientID, @CourierID, @StatusID, @StatusDateTime, @SendingAddress, @ArrivalAddress, @RecieverFullName, @RecieverPhone, @AcceptDateTime, @SendingDateTime, @ArrivalDateTime, @Weight, @DeliveryPrice)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ClientID", clientId);
            command.Parameters.AddWithValue("CourierID", courierId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("StatusID", (int)status);
            command.Parameters.AddWithValue("StatusDateTime", statusDateTime);
            command.Parameters.Add(new SqlParameter("@SendingAddress", SqlDbType.NVarChar, 100)).Value = sendingAddress.ToString();
            command.Parameters.Add(new SqlParameter("@ArrivalAddress", SqlDbType.NVarChar, 100)).Value = arrivalAddress.ToString();
            command.Parameters.Add(new SqlParameter("@RecieverFullName", SqlDbType.NVarChar, 100)).Value = recieverFullName;
            command.Parameters.AddWithValue("RecieverPhone", recieverPhone);
            command.Parameters.AddWithValue("AcceptDateTime", acceptDateTime ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("SendingDateTime", sendingDateTime ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("ArrivalDateTime", arrivalDateTime ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("Weight", parcelWeight);
            command.Parameters.AddWithValue("DeliveryPrice", deliveryPrice);

            command.ExecuteNonQuery();
        }

        public static int CountPersonsWithEmailAndPhone(string email, string phone)
        {
            const string query = "SELECT COUNT(*) FROM Person WHERE Email = @email AND Phone = @phone";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("phone", phone);

            return (int)command.ExecuteScalar();
        }

        public static UserData GetPerson(string email, string password)
        {
            const string getQuery = "SELECT ID, FullName, Phone, Role FROM Person WHERE Email = @email AND Password = @password";
            SqlCommand getCommand = new SqlCommand(getQuery, connection);
            getCommand.Parameters.AddWithValue("email", email);
            getCommand.Parameters.AddWithValue("password", password);

            int id;
            string fullName;
            string phone;
            string role;

            using (SqlDataReader reader = getCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Якщо знайшли користувача...
                    id = (int)reader[0];
                    fullName = (string)reader[1];
                    phone = (string)reader[2];
                    role = (string)reader[3];
                }
                else
                {
                    // Якщо не знайшли користувача з таким email та паролем
                    throw new ArgumentException("Введений email або пароль неправильний.");
                }
            }

            return new UserData(id, email, password, fullName, phone, role);
        }

        public static int GetLastIDFromTable(string tableName)
        {
            string query = $"SELECT TOP 1 id FROM {tableName} ORDER BY id DESC";

            SqlCommand command = new SqlCommand(query, connection);

            return (int)command.ExecuteScalar();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static List<Parcel> GetClientParcels(int clientID)
        {
            const string getQuery = "SELECT * FROM Parcel WHERE clientID = @clientID";
            SqlCommand getCommand = new SqlCommand(getQuery, connection);
            getCommand.Parameters.AddWithValue("clientID", clientID);

            List<Parcel> parcels = new List<Parcel>();

            using (SqlDataReader reader = getCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = (int)reader[0];
                    // Тут пропускаємо номер клієнта
                    int? courierID = Convert.IsDBNull(reader[2]) ? null : (int?)reader[2];
                    int statusID = (int)reader[3];
                    DateTime statusDateTime = (DateTime)reader[4];
                    Address sendingAddress = Address.ToAddress((string)reader[5]);
                    Address arrivalAddress = Address.ToAddress((string)reader[6]);
                    string recieverFullName = (string)reader[7];
                    string recieverPhone = (string)reader[8];
                    DateTime? acceptDateTime = Convert.IsDBNull(reader[9]) ? null : (DateTime?)reader[9];
                    DateTime? sendingDateTime = Convert.IsDBNull(reader[10]) ? null : (DateTime?)reader[10];
                    DateTime? arrivalDateTime = Convert.IsDBNull(reader[11]) ? null : (DateTime?)reader[11];
                    double weight = (double)reader[12];
                    int deliveryPrice = (int)reader[13];

                    Parcel parcel = new(id, clientID, courierID, statusID, statusDateTime, sendingAddress, arrivalAddress, recieverFullName, recieverPhone, acceptDateTime, sendingDateTime, arrivalDateTime, (float)weight, deliveryPrice);
                
                    parcels.Add(parcel);
                }
            }

            return parcels;
        }

        public static string GetPersonFullName(int id)
        {
            const string query = "SELECT fullName FROM Person WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);

            string fullName;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    fullName = (string)reader[0];
                }
                else
                {
                    throw new ArgumentException("Не знайдено персони за даним ID");
                }
            }

            return fullName;
        }

        public static void ChangeParcelStatus(int id, ParcelStatus status)
        {
            const string query = "UPDATE Parcel SET statusID = @statusID, statusDateTime = @statusDateTime WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("statusID", (int)status);
            command.Parameters.AddWithValue("statusDateTime", DateTime.Now);
            command.Parameters.AddWithValue("ID", id);

            command.ExecuteNonQuery();
        }

        public static List<UserData> GetPersonsByRole(string role)
        {
            const string query = "SELECT * FROM Person WHERE Role = @role";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("role", role);

            List<UserData> persons = new List<UserData>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = (int)reader[0];
                    string email = (string)reader[1];
                    string password= (string)reader[2];
                    string fullName = (string)reader[3];
                    string phone = (string)reader[4];

                    UserData person = new UserData(id, email, password, fullName, phone, role);

                    persons.Add(person);
                }
            }

            return persons;
        }

        public static void DeleteParcel(int id)
        {
            const string query = "DELETE FROM Parcel WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);

            command.ExecuteNonQuery();
        }

        public static List<Parcel> GetCourierParcels(int courierID, bool exceptCanceled = false)
        {
            const string getQuery = "SELECT * FROM Parcel WHERE courierID = @courierID";
            SqlCommand getCommand = new SqlCommand(getQuery, connection);
            getCommand.Parameters.AddWithValue("courierID", courierID);

            List<Parcel> parcels = new List<Parcel>();

            using (SqlDataReader reader = getCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = (int)reader[0];
                    int clientID = (int)reader[1];
                    // Тут пропускаємо кур'єра
                    int statusID = (int)reader[3];
                    DateTime statusDateTime = (DateTime)reader[4];
                    Address sendingAddress = Address.ToAddress((string)reader[5]);
                    Address arrivalAddress = Address.ToAddress((string)reader[6]);
                    string recieverFullName = (string)reader[7];
                    string recieverPhone = (string)reader[8];
                    DateTime? acceptDateTime = Convert.IsDBNull(reader[9]) ? null : (DateTime?)reader[9];
                    DateTime? sendingDateTime = Convert.IsDBNull(reader[10]) ? null : (DateTime?)reader[10];
                    DateTime? arrivalDateTime = Convert.IsDBNull(reader[11]) ? null : (DateTime?)reader[11];
                    double weight = (double)reader[12];
                    int deliveryPrice = (int)reader[13];

                    Parcel parcel = new(id, clientID, courierID, statusID, statusDateTime, sendingAddress, arrivalAddress, recieverFullName, recieverPhone, acceptDateTime, sendingDateTime, arrivalDateTime, (float)weight, deliveryPrice);

                    // Якщо треба показати без скасованих клієнтом
                    if (exceptCanceled && (ParcelStatus)parcel.statusId == ParcelStatus.Canceled)
                    {
                        continue;
                    }

                    parcels.Add(parcel);
                }
            }

            return parcels;
        }

        public static List<Parcel> GetAllParcels()
        {
            const string getQuery = "SELECT * FROM Parcel";
            SqlCommand getCommand = new SqlCommand(getQuery, connection);

            List<Parcel> parcels = new List<Parcel>();

            using (SqlDataReader reader = getCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = (int)reader[0];
                    int clientID = (int)reader[1];
                    int? courierID = Convert.IsDBNull(reader[2]) ? null : (int?)reader[2];
                    int statusID = (int)reader[3];
                    DateTime statusDateTime = (DateTime)reader[4];
                    Address sendingAddress = Address.ToAddress((string)reader[5]);
                    Address arrivalAddress = Address.ToAddress((string)reader[6]);
                    string recieverFullName = (string)reader[7];
                    string recieverPhone = (string)reader[8];
                    DateTime? acceptDateTime = Convert.IsDBNull(reader[9]) ? null : (DateTime?)reader[9];
                    DateTime? sendingDateTime = Convert.IsDBNull(reader[10]) ? null : (DateTime?)reader[10];
                    DateTime? arrivalDateTime = Convert.IsDBNull(reader[11]) ? null : (DateTime?)reader[11];
                    double weight = (double)reader[12];
                    int deliveryPrice = (int)reader[13];

                    Parcel parcel = new(id, clientID, courierID, statusID, statusDateTime, sendingAddress, arrivalAddress, recieverFullName, recieverPhone, acceptDateTime, sendingDateTime, arrivalDateTime, (float)weight, deliveryPrice);

                    parcels.Add(parcel);
                }
            }

            return parcels;
        }

        public static void InsertTransport(int id, string transportType, string? transportNumber)
        {
            string query = "INSERT INTO Transport (courierID, transportType, transportNumber)";
            query += "VALUES (@courierID, @transportType, @transportNumber)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("courierID", id);
            command.Parameters.Add(new SqlParameter("@transportType", SqlDbType.NVarChar, 100)).Value = transportType;
            command.Parameters.AddWithValue("transportNumber", transportNumber ?? (object)DBNull.Value);

            command.ExecuteNonQuery();
        }

        public static Transport GetTransport(int courierId)
        {
            const string query = "SELECT * FROM Transport WHERE courierID = @courierID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("courierID", courierId);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    int transportId = (int)reader[0];
                    // Пропускаємо ID кур'єра
                    string transportType = (string)reader[2];
                    string? transportNumber = Convert.IsDBNull(reader[3]) ? null : (string?)reader[3];

                    return new Transport(transportId, courierId, transportType, transportNumber);
                }
                else
                {
                    return new Transport(null, null, null, null);
                }
            }
        }

        public static List<Parcel> GetAvailibleParcels()
        {
            const string query = "SELECT * FROM Parcel WHERE statusID = @statusID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("statusID", (int)ParcelStatus.Registered);

            List<Parcel> parcels = new List<Parcel>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = (int)reader[0];
                    int clientID = (int)reader[1];
                    int? courierID = Convert.IsDBNull(reader[2]) ? null : (int?)reader[2];
                    int statusID = (int)reader[3];
                    DateTime statusDateTime = (DateTime)reader[4];
                    Address sendingAddress = Address.ToAddress((string)reader[5]);
                    Address arrivalAddress = Address.ToAddress((string)reader[6]);
                    string recieverFullName = (string)reader[7];
                    string recieverPhone = (string)reader[8];
                    DateTime? acceptDateTime = Convert.IsDBNull(reader[9]) ? null : (DateTime?)reader[9];
                    DateTime? sendingDateTime = Convert.IsDBNull(reader[10]) ? null : (DateTime?)reader[10];
                    DateTime? arrivalDateTime = Convert.IsDBNull(reader[11]) ? null : (DateTime?)reader[11];
                    double weight = (double)reader[12];
                    int deliveryPrice = (int)reader[13];

                    Parcel parcel = new(id, clientID, courierID, statusID, statusDateTime, sendingAddress, arrivalAddress, recieverFullName, recieverPhone, acceptDateTime, sendingDateTime, arrivalDateTime, (float)weight, deliveryPrice);

                    parcels.Add(parcel);
                }
            }

            return parcels;
        }

        public static void ChangeParcelCourier(int parcelId, int? courierId)
        {
            const string query = "UPDATE Parcel SET courierID = @courierID WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("courierID", courierId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("ID", parcelId);

            command.ExecuteNonQuery();
        }

        public static void ChangeParcelDateTime(int parcelId, string dateTimeName, DateTime? dateTime)
        {
            string query = $"UPDATE Parcel SET {dateTimeName} = @{dateTimeName} WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue($"{dateTimeName}", dateTime ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("ID", parcelId);

            command.ExecuteNonQuery();
        }

        public static string GetPersonPhone(int personId)
        {
            const string query = "SELECT phone FROM Person WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID", personId);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return (string)reader[0];

                }
                else
                {
                    throw new ArgumentException($"Не знайдено телефону для людини (ID: {personId})!");
                }
            }
        }

        public static List<(UserData courier, Transport transport)> GetAllCourierAndTransport()
        {
            const string query = "SELECT * FROM Person INNER JOIN Transport ON Transport.courierID = Person.ID";
            SqlCommand command = new SqlCommand(query, connection);

            List<(UserData, Transport)> result = new();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = (int)reader[0];
                    string email = (string)reader[1];
                    string password = (string)reader[2];
                    string fullName = (string)reader[3];
                    string phone = (string)reader[4];
                    string role = (string)reader[5];

                    int transportId = (int)reader[6];
                    string transportType = (string)reader[8];
                    string? transportNumber = Convert.IsDBNull(reader[9]) ? null : (string?)reader[9];

                    UserData courier = new UserData(id, email, password, fullName, phone, role);
                    Transport transport = new Transport(transportId, id, transportType, transportNumber);

                    result.Add((courier, transport));
                }
            }

            return result;
        }

        public static UserData GetPerson(int personId)
        {
            const string getQuery = "SELECT * FROM Person WHERE ID = @id";
            SqlCommand getCommand = new SqlCommand(getQuery, connection);
            getCommand.Parameters.AddWithValue("id", personId);

            string email;
            string password;
            string fullName;
            string phone;
            string role;

            using (SqlDataReader reader = getCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Якщо знайшли користувача...
                    email = (string)reader[1];
                    password = (string)reader[2];
                    fullName = (string)reader[3];
                    phone = (string)reader[4];
                    role = (string)reader[5];
                }
                else
                {
                    // Якщо не знайшли користувача з таким email та паролем
                    throw new ArgumentException($"Не знайдено користувача (ID: {personId}).");
                }
            }

            return new UserData(personId, email, password, fullName, phone, role);
        }

        // ParcelsStats - список з кількостями посилок до кожної категорії.
        // [0] - Всі загалом
        // [1] - Доставлені
        // [2] - Скасовані
        // [3] - В дорозі
        public static (UserData courier, List<int> parcelsStats) GetCourierAndParcelsStats(int courierId, DateTime? from, DateTime? to)
        {
            UserData courier = GetPerson(courierId);

            List<Parcel> parcels = GetCourierParcels(courierId);

            int countAll = 0;
            int countDelivered = 0;
            int countCanceled = 0;
            int countTransit = 0;

            foreach (Parcel parcel in parcels)
            {
                DateTime? date = parcel.acceptDateTime;

                if (from is not null && to is not null) // Ця перевірка треба, щоб зрозуміти, чи це статистика за весь час, чи ні
                {
                    if (date < from || to < date)
                    {
                        continue;
                    }
                }

                ParcelStatus status = (ParcelStatus)parcel.statusId;

                switch (status)
                {
                    case ParcelStatus.Completed:
                        countDelivered++;
                        break;
                    case ParcelStatus.Canceled: 
                        countCanceled++;
                        break;
                    case ParcelStatus.InTransit: 
                        countTransit++;
                        break;
                }

                countAll++;
            }

            List<int> parcelsStats = new List<int>();

            parcelsStats.Add(countAll);
            parcelsStats.Add(countDelivered);
            parcelsStats.Add(countCanceled);
            parcelsStats.Add(countTransit);

            return (courier, parcelsStats);
        }
    }
}
