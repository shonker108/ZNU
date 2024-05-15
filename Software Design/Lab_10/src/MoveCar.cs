using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10.src
{
    public class MoveCar : IMoveStrategy
    {
        public void Move()
        {
            Console.WriteLine("Рух здійснюється машиною");
        }
    }
}
