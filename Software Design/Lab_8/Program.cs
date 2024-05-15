using Lab_8.src;

namespace Lab_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            // #####################    Прототип            #####################

            // Треба створити 3 роботи з лише 1-го, які працюють водіями
            Robot r1 = new Robot(812413, RobotType.Driver);

            Robot r2 = r1.Clone();

            Robot r3 = r1.DeepClone();

            r1.PrintRobotInfo();
            r2.PrintRobotInfo();
            r3.PrintRobotInfo();

            // Робот 1 тепер працює шеф-кухарем
            r1.type = RobotType.Chef;

            // Але тепер і 2-й робот також працює шеф-кухарем,
            // а 3-й - ні
            r1.PrintRobotInfo();
            r2.PrintRobotInfo();
            r3.PrintRobotInfo();

            // #####################    Абстрактна фабрика  #####################

            TruckFactory truckFactory = new TruckFactory();
            PassengerCarFactory passengerCarFactory = new PassengerCarFactory();

            List<ICar> autopark = new List<ICar>();

            // До автопарку додамо 2 вантажівки та 2 легкових автомобілі
            autopark.Add(truckFactory.MakeCar("Renault"));
            autopark.Add(passengerCarFactory.MakeCar("Ford"));
            autopark.Add(truckFactory.MakeCar("Mercedes"));
            autopark.Add(passengerCarFactory.MakeCar("BMW"));

            foreach (ICar car in autopark)
            {
                car.Drive();
            }
        }
    }
}
