using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.src
{
    public class PassengerCar : ICar
    {
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Model} passenger car has just driven away");
        }
    }
}
