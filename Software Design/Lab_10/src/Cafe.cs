using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10.src
{
    public class Cafe
    {
        public void MakeCoffee(CoffeeClient client)
        {
            Console.WriteLine($"Клієнту {client.Name} було продано каву");
        }

        public void MakeHotdog(HotdogClient client)
        {
            Console.WriteLine($"Клієнту {client.Name} було продано хот-дог");
        }

        public void MakeFries(FriesClient client)
        {
            Console.WriteLine($"Клієнту {client.Name} було продано картоплю фрі");
        }
    }
}
