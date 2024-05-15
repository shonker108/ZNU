using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.src
{
    public class PassengerCarFactory : IFactory
    {
        public ICar MakeCar(string model)
        {
            PassengerCar car = new PassengerCar();
            car.Model = model;

            return car;
        }
    }
}
