using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class LogData
    {
        public DateTime dateTime;
        public char character;
        public int selectorRow;
        public int selectorColumn;
        public string eventType;

        public LogData(DateTime dateTime, char character, int selectorRow, int selectorColumn, string eventType)
        {
            this.dateTime = dateTime;
            this.character = character;
            this.selectorRow = selectorRow;
            this.selectorColumn = selectorColumn;
            this.eventType = eventType;
        }

        public override string ToString()
        {
            return $"{dateTime}: CHAR: {character}; POS: ROW: {selectorRow}, COL: {selectorColumn}; EVENT: {eventType}";
        }
    }
}
