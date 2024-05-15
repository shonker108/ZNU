using Lab_6.MyClasses;
using Lab_6.src;
using System.Diagnostics.Contracts;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1
            ResearchTeam team1 = new ResearchTeam();
            team1.AddFromConsole();

            ResearchTeam team2 = team1.DeepCopy();

            Console.WriteLine("**Оригінальний об'єкт:**");
            Console.WriteLine(team1);

            Console.WriteLine("**Копія об'єкта:**");
            Console.WriteLine(team2);

            // 2
            Console.WriteLine("Введіть ім'я файлу для збереження: ");
            string filename = Console.ReadLine();

            // 3
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не існує. Створено новий файл.");
                File.Create(filename);
            }

            ResearchTeam team3 = new ResearchTeam();
            team3.Load(filename);

            Console.WriteLine("**Об'єкт після завантаження з файлу:**");
            Console.WriteLine(team3);

            // 4
            team3.AddFromConsole();
            team3.Save(filename);

            Console.WriteLine("**Об'єкт після додавання публікації:**");
            Console.WriteLine(team3);

            // 5
            ResearchTeam.Load(filename, team3);
            team3.AddFromConsole();
            ResearchTeam.Save(filename, team3);

            Console.WriteLine("**Об'єкт після повторного завантаження та додавання публікації:**");
            Console.WriteLine(team3);
        }
    }
}
