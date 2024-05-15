using Lab_10.src;

namespace Lab_10
{
    public enum TerrainType
    {
        Lake,
        Road,
        Trail // Стежка
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Стратегія
            Random random = new Random();

            Character character = new Character();

            int movesCount = 5;
            while (movesCount > 0)
            {
                TerrainType type = (TerrainType)random.Next(3);

                switch (type)
                {
                    case TerrainType.Lake:
                        Console.WriteLine("Персонаж натрапив на озеро...");
                        character.ChangeMoveStrategy(new MoveBoat());
                        break;
                    case TerrainType.Road:
                        Console.WriteLine("Персонаж натрапив на дорогу...");
                        character.ChangeMoveStrategy(new MoveCar());
                        break;
                    case TerrainType.Trail:
                        Console.WriteLine("Персонаж натрапив на стежку...");
                        character.ChangeMoveStrategy(new MoveBarefoot());
                        break;
                }

                character.Move();

                movesCount--;
            }

            // Відвідувач
            Cafe cafe = new Cafe(); // В нашому випадку, кафе - це відвідувач

            IClient[] clients = new IClient[]
            {
                new CoffeeClient("Гілберт"),
                new FriesClient("Мет'ю"),
                new HotdogClient("Макс"),
                new CoffeeClient("Алекс"),
                new HotdogClient("Настя")
            };

            foreach (IClient client in clients)
            {
                client.OrderFood(cafe);
            }
        }
    }
}
