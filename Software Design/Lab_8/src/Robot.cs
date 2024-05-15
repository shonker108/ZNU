using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.src
{
    public enum RobotType
    {
        Builder,
        Chef,
        Driver,
        Miner
    }
    public class Robot : IClone<Robot>
    {
        public int serialNumber;
        public RobotType type;

        public Robot(int serialNumber, RobotType type)
        {
            this.serialNumber = serialNumber;
            this.type = type;
        }
        
        public Robot Clone()
        {
            return this;
        }

        public Robot DeepClone()
        {
            return new Robot(this.serialNumber, this.type);
        }

        public void PrintRobotInfo()
        {
            Console.WriteLine($"Robot #{serialNumber} works as a {type.ToString()}");
        }
    }
}
