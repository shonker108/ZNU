using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10.src
{
    public interface IClient
    {
        public string Name { get; set; }

        public void OrderFood(Cafe cafe);
    }
}
