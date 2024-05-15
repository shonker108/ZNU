using Lab_6.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.src
{
    public class ComparingHelper : IComparer<ResearchTeam>
    {
        public int Compare(ResearchTeam? x, ResearchTeam? y)
        {
            return x.Papers.Count - y.Papers.Count;
        }
    }
}
