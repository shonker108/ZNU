using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9.src
{
    public class Client
    {
        public void OrderFood(Restraunt restraunt, string food)
        {
            restraunt.GetOrder(food);
        }
    }
}
