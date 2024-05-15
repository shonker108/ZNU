using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9.src
{
    public class App
    {
        public ILogger logger;

        public App(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogIn(string password)
        {
            logger.LogIn(password);
        }
    }
}
