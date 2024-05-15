using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.src
{
    public class TruckFactory : IFactory
    {
        public ICar MakeCar(string model)
        {
            Truck car = new Truck();
            car.Model = model;

            return car;
        }
    }
}
