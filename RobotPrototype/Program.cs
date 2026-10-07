
namespace RobotPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            RobotFactory factory = new RobotFactory();

            
            ServiceRobot serviceRobot = new ServiceRobot(
                "SR-100",
                15,
                "v1.0",
                "Hospital Assistance"
            );

            IndustrialRobot industrialRobot = new IndustrialRobot(
                "IR-200",
                29,
                "v2.1",
                "Welding"
            );

            EntertainmentRobot entertainmentRobot = new EntertainmentRobot(
                "ER-300",
                15,
                "v1.5",
                "Dancing"
            );

            
            factory.RegisterRobot("service", serviceRobot);
            factory.RegisterRobot("industrial", industrialRobot);
            factory.RegisterRobot("entertainment", entertainmentRobot);

         
            ServiceRobot customerServiceRobot =
                (ServiceRobot)factory.CloneRobot("service");

            customerServiceRobot.ModelName = "SR-101";
            customerServiceRobot.BatteryCapacity = 15;
            customerServiceRobot.SoftwareVersion = "v1.1";

            
            IndustrialRobot customerIndustrialRobot =
                (IndustrialRobot)factory.CloneRobot("industrial");

            customerIndustrialRobot.ModelName = "IR-201";
            customerIndustrialRobot.BatteryCapacity = 30;
            customerIndustrialRobot.SoftwareVersion = "v2.2";

            
            EntertainmentRobot customerEntertainmentRobot =
                (EntertainmentRobot)factory.CloneRobot("entertainment");

            customerEntertainmentRobot.ModelName = "ER-301";
            customerEntertainmentRobot.BatteryCapacity = 14;
            customerEntertainmentRobot.SoftwareVersion = "v1.6";

            
         

            serviceRobot.DisplayInfo();
            Console.WriteLine();

            industrialRobot.DisplayInfo();
            Console.WriteLine();

            entertainmentRobot.DisplayInfo();

            

            customerServiceRobot.DisplayInfo();
            Console.WriteLine();

            customerIndustrialRobot.DisplayInfo();
            Console.WriteLine();

            customerEntertainmentRobot.DisplayInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}