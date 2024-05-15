using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9.src
{
    public class Logger : ILogger
    {
        private string password;

        public Logger(string password)
        {
            this.password = password;
        }

        public bool LogIn(string password)
        {
            if (this.password == password)
            {
                Console.WriteLine("Успішно здійснено вхід!");
                return true;
            }
            else
            {
                Console.WriteLine("Невдала спроба входу!");
                return false;
            }
        }
    }
}
