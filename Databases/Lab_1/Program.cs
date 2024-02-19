using Util;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager dbManager = new DatabaseManager("db/orders.database");

            Console.WriteLine("Loading the database...");

            if (!dbManager.LoadDatabase())
            {
                Console.WriteLine("Can't load the database. Exiting the program...");
                Thread.Sleep(1000);
                return;
            }

            Console.WriteLine("Loaded the database successfully!");
            Thread.Sleep(1000);
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Choose an action:\n1 - View all orders\n2 - Create a new order\n3 - Edit an order\n4 - Delete an order\n5 - Exit the program\n");
                Console.Write("Your action: ");
               
                char action = Console.ReadKey().KeyChar;

                while (action < '1' && action > '5')
                {
                    Console.Clear();
                    Console.WriteLine("Unknown action... Try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    
                    Console.WriteLine("Choose an action:\n1 - View all orders\n2 - Create a new order\n3 - Edit an order\n4 - Delete an order\n5 - Exit the program\n");
                    Console.Write("Your action: ");

                    action = Console.ReadKey().KeyChar;
                }

                Thread.Sleep(1000);
                Console.Clear();

                bool exit = false;

                switch (action)
                {
                    case '1':
                        dbManager.ViewAllOrders();
                        break;
                    case '2':
                        dbManager.AddNewOrder();
                        break;
                    case '3':
                        dbManager.EditOrder();
                        break;
                    case '4':
                        dbManager.DeleteOrder();
                        break;
                    case '5':
                        exit = true;
                        break;
                }


                if (exit)
                    break;
            }

            Console.Clear();
            Console.WriteLine("Saving the database...");

            dbManager.SaveDatabase();

            Console.WriteLine("Successfully saved the database!");
        }
    }
}
