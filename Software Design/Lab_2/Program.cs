namespace Lab_6
{
    internal class Program
    {
        const string inputPath = "input.txt";
        const string outputPath = "output.txt";

        private static Random random = new Random();
        static void Main(string[] args)
        {
            // Зчитування даних з файлу з масивом
            string[] lines = File.ReadAllLines(inputPath);

            int m = lines.Length;
            int n = lines.Length;

            int[][] arr = new int[m][];

            int product = 1;

            for (int i = 0; i < m; i++)
            {
                arr[i] = new int[n];

                string[] row = lines[i].Split(' ');

                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = int.Parse(row[j]);

                    Console.Write($"{arr[i][j]}\t");

                    // Якщо ми на головній діагоналі, домножити до результату значення з масиву
                    if (i == j && arr[i][j] < 0)
                        product *= arr[i][j];
                }

                Console.WriteLine();
            }

            string result = $"Product = {product}";
            Console.WriteLine(result);

            // Збереження результату в інший файл
            File.WriteAllText(outputPath, result);
        }
    }
}
