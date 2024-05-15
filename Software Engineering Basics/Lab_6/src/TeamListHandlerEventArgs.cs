using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.src
{
    public class TeamListHandlerEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string ChangeType { get; set; }
        public int Index { get; set; }

        public TeamListHandlerEventArgs(string name, string changeType, int index)
        {
            Name = name;
            ChangeType = changeType;
            Index = index;
        }

        public override string ToString()
        {
            return $"Name: {Name}, ChangeType: {ChangeType}, Index: {Index}";
        }
    }
}
