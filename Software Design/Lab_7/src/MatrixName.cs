using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7.src
{
    public class MatrixName
    {
        private string name;

        public MatrixName(string name)
        {
            this.name = name;
        }

        public void PrintName()
        {
            Console.WriteLine(this.name);
        }
    }
}
