using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.src
{
    public interface IFactory
    {
        public ICar MakeCar(string model);
    }
}
