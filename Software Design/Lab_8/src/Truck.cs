using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.src
{
    public class Truck : ICar
    {
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Model} truck has just driven away");
        }
    }
}
