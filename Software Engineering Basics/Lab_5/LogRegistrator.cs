using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Lab_5
{
    public class LogRegistrator
    {
        private const string logDataFilePath = "D:\\repos\\ZNU\\Software Engineering Basics\\Lab_5\\bin\\Debug\\net8.0-windows\\logdata.txt";
        private List<LogData> sessionLogData = new List<LogData>();

        public LogRegistrator() { }
        public void AddLog(LogData logData)
        {
            sessionLogData.Add(logData);
        }
        public void SaveLog()
        {
            using (StreamWriter writer = new StreamWriter(logDataFilePath))
            {
                foreach (var logData in sessionLogData)
                {
                    writer.WriteLine(logData.ToString());
                }
            }
        }
    }
}
