using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.src
{
    public interface INameAndCopy
    {
        protected string Name { get; set; }
        object DeepCopy();
    }
}
