using MyStructs;
using System;
using System.Collections.Generic;

namespace Util
{
    public class DatabaseManager
    {
        private List<Order> ordersDatabase;
        private string databasePath;
        public DatabaseManager(string databasePath)
        {
            ordersDatabase = new List<Order>();

            this.databasePath = databasePath;
        }

        // Returns true if the database was successfully loaded
        public bool LoadDatabase()
        {
            var lines = File.ReadAllLines(databasePath);

            if (lines.Length == 0)
            {
                Console.WriteLine("The database is empty!");
                return false;
            }

            int i = 0;

            while (i < lines.Length)
            {
                Order order = new Order();

                // Load User
                User user = new User();
                user.firstName = lines[i++];
                user.lastName = lines[i++];
                user.email = lines[i++];

                order.user = user;

                order.shippingAddress = lines[i++];

                // Load User's ordered items
                List<Item> items = new List<Item>();

                // After the last User's ordered item will
                // always be an empty string
                while (i < lines.Length && lines[i] != "")
                {
                    Item item = new Item();
                    item.name = lines[i++];

                    // Only these two variables are of a numeric type
                    item.count = int.Parse(lines[i++]);
                    item.pricePerOne = float.Parse(lines[i++]);

                    items.Add(item);
                }

                // Skip an empty string
                i++;

                order.items = items;

                // Load the order to the DB
                ordersDatabase.Add(order);
            }

            return true;
        }

        public void SaveDatabase()
        {
            string dataToSave = "";

            foreach (Order order in ordersDatabase)
            {
                // User
                dataToSave += order.user.firstName + '\n';
                dataToSave += order.user.lastName + '\n';
                dataToSave += order.user.email+ '\n';

                // Shipping address
                dataToSave += order.shippingAddress + '\n';

                // Items
                foreach (Item item in order.items)
                {
                    dataToSave += item.name + "\n";
                    dataToSave += item.count.ToString() + "\n";
                    dataToSave += item.pricePerOne.ToString() + "\n";
                }

                dataToSave += '\n';
            }

            File.WriteAllText(databasePath, dataToSave);
        }

        public void ViewAllOrders()
        {
            for (int i = 0; i < ordersDatabase.Count; i++)
            {
                Order order = ordersDatabase[i];

                Console.WriteLine($"Order #{i + 1} ----------");

                Console.WriteLine(" User");
                Console.WriteLine($"  * First name: {order.user.firstName}");
                Console.WriteLine($"  * Last name: {order.user.lastName}");
                Console.WriteLine($"  * Email: {order.user.email}");
                Console.WriteLine();

                Console.WriteLine(" Items");
                foreach (Item item in order.items)
                {
                    Console.WriteLine($"  * Name: {item.name}");
                    Console.WriteLine($"  * Count: {item.count}");
                    Console.WriteLine($"  * Price per one: ${item.pricePerOne}");
                    Console.WriteLine();
                }

                Console.WriteLine($" Shipping address: {order.shippingAddress}");
                Console.WriteLine();
            }

            Console.WriteLine("Press Enter to continue...");

            Console.Read();
            Thread.Sleep(1000);
            Console.Clear();
        }

        public void AddNewOrder()
        {
            Order order = new Order();

            // Initializing new order info
            Console.WriteLine("User info");

            User user = new User();

            Console.Write("First name: ");
            user.firstName = Console.ReadLine()!;

            Console.Write("Last name: ");
            user.lastName = Console.ReadLine()!;

            Console.Write("Email: ");
            user.email = Console.ReadLine()!;

            order.user = user;

            Thread.Sleep(1000);
            Console.Clear();

            Console.Write("Shipping address: ");
            order.shippingAddress = Console.ReadLine()!;

            List<Item> items = new List<Item>();

            while (true)
            {
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine("Item info");

                Item item = new Item();

                Console.Write("Name: ");
                item.name = Console.ReadLine()!;

                Console.Write("Count: ");
                if (!int.TryParse(Console.ReadLine(), out int count))
                {
                    Console.WriteLine("Can't parse given count! Try again.");

                    continue;
                }

                item.count = count;

                Console.Write("Price per one (USD): ");
                if (!float.TryParse(Console.ReadLine(), out float pricePerOne))
                {
                    Console.WriteLine("Can't parse given price! Try again.");

                    continue;
                }

                item.pricePerOne = pricePerOne;

                items.Add(item);

                Console.WriteLine("Add another item? (Press 'y')");

                char input = char.ToLower(Console.ReadKey().KeyChar);

                if (input != 'y')
                    break;
            }

            order.items = items;

            ordersDatabase.Add(order);

            Console.WriteLine("Successfully added a new order to the database!");

            Thread.Sleep(1000);
            Console.Clear();
        }

        public void EditOrder()
        {
            if (ordersDatabase.Count <= 0)
            {
                Console.WriteLine("The database if empty. Returning to the menu.");
                return;
            }

            Console.Clear();
            Console.Write("Enter an index of the order: ");

            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine("Can't parse given index! Returnnig to the menu.");
                return;
            }
            else
            {
                if (index < 1 || index >= ordersDatabase.Count)
                {
                    Console.WriteLine("Can't find an order with a given index. Returning to the menu");
                    return;
                }
            }

            Order order = ordersDatabase[index - 1];

            // Initializing new order info
            Console.WriteLine("User info");

            User user = new User();

            Console.Write("First name: ");
            user.firstName = Console.ReadLine()!;

            if (user.firstName == "")
                user.firstName = order.user.firstName;

            Console.Write("Last name: ");
            user.lastName = Console.ReadLine()!;

            if (user.lastName == "")
                user.lastName = order.user.lastName;

            Console.Write("Email: ");
            user.email = Console.ReadLine()!;

            if (user.email == "")
                user.email = order.user.email;

            order.user = user;

            Thread.Sleep(1000);
            Console.Clear();

            Console.Write("Shipping address: ");
            string shippingAddress = Console.ReadLine()!;

            if (shippingAddress != "")
                order.shippingAddress = shippingAddress;

            List<Item> items = new List<Item>();

            for (int i = 0; i < order.items.Count; i++)
            {
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine($"Item #{i + 1} info");

                Item item = order.items[i];

                Console.Write("Name: ");
                item.name = Console.ReadLine()!;

                if (item.name == "")
                    item.name = order.items[i].name;

                Console.Write("Count (Enter anything but not a number to keep the value the same): ");
                if (int.TryParse(Console.ReadLine(), out int count))
                {
                    item.count = count;
                }

                Console.Write("Price per one (USD) (Enter anything but not a number to keep the value the same): ");
                if (float.TryParse(Console.ReadLine(), out float pricePerOne))
                {
                    item.pricePerOne = pricePerOne;
                }

                items.Add(item);
            }

            order.items = items;

            ordersDatabase[index - 1] = order;

            Console.WriteLine($"Successfully edited the order #{index}");
        }

        public void DeleteOrder()
        {
            if (ordersDatabase.Count <= 0)
            {
                Console.WriteLine("The database if empty. Returning to the menu.");
                return;
            }

            Console.Clear();
            Console.Write("Enter an index of the order: ");

            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine("Can't parse given index! Returnnig to the menu.");
                return;
            }
            else
            {
                if (index < 1 || index >= ordersDatabase.Count)
                {
                    Console.WriteLine("Can't find an order with a given index. Returning to the menu");
                    return;
                }
            }

            ordersDatabase.RemoveAt(index - 1);

            Console.WriteLine($"Successfully deleted the order #{index}");
        }
    }
}
