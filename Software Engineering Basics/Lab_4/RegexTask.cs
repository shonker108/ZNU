using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_4
{
    static public class RegexTask
    {
        static public void Activate(string text, string pattern)
        {
            Match match = Regex.Match(text, pattern);

            if (match.Success)
            {
                InfoForm infoForm = new InfoForm(match.Value, "Regex result");
                infoForm.Show();
            }
            else
            {
                InfoForm infoForm = new InfoForm("Regex hasn't found any matches in text", "Regex result");
                infoForm.Show();
            }
        }
    }
}
