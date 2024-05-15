using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9.src
{
    public class SecureLogger : ILogger
    {
        private int unsuccessfullLogins = 0;
        private int maxUnsuccessfullLogins = 3;
        private Logger logger;

        public SecureLogger(string password)
        {
            logger = new Logger(password);
        }
        public bool LogIn(string password)
        {
            if (unsuccessfullLogins >= maxUnsuccessfullLogins)
            {
                Console.WriteLine("Вам відмовлено у спробі авторизації!");
                return false;
            }
            
            if (!logger.LogIn(password))
            {
                unsuccessfullLogins++;
                return false;
            }
            else
            {
                unsuccessfullLogins = 0;
                return true;
            }
        }
    }
}
