namespace Lab_1
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            // Якщо треба знайти добуток елементів на головній діагоналі масиву,
            // то він має бути квадратним
            int m = GetUserInput("Enter M");

            int[][] arr = new int[m][];

            int product = 1;

            for (int i = 0; i < m; i++)
            {
                arr[i] = new int[m];

                for (int j = 0; j < m; j++)
                {
                    // Числа будуть у діапазоні від -10 до 10, попри 11 в кінці
                    arr[i][j] = random.Next(-10, 11);

                    Console.Write($"{arr[i][j]}\t");

                    // Якщо ми на головній діагоналі, домножити до результату значення з масиву
                    if (i == j)
                        product *= arr[i][j];
                }

                Console.WriteLine();
            }

            Console.WriteLine("Product = " + product);
        }

        private static int GetUserInput(string message)
        {
            Console.WriteLine(message);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int input))
                    return input;
            }
        }
    }
}
