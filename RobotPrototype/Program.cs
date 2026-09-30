namespace RobotPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the original Service Robot
            ServiceRobot serviceRobot =
                new ServiceRobot("ServiceBot-X1", 10, "v1.0");

            Console.WriteLine("=== Original Service Robot ===");
            serviceRobot.DisplayInfo();
            serviceRobot.ServiceTask();

            Console.WriteLine();

            // Clone the Service Robot
            ServiceRobot clonedServiceRobot =
                (ServiceRobot)serviceRobot.Clone();

            // Customize the cloned robot
            clonedServiceRobot.ModelName = "ServiceBot-X2";
            clonedServiceRobot.BatteryCapacity = 15;
            clonedServiceRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("=== Cloned Service Robot ===");
            clonedServiceRobot.DisplayInfo();
            clonedServiceRobot.ServiceTask();

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            // Create the original Industrial Robot
            IndustrialRobot industrialRobot =
                new IndustrialRobot("IndustrialBot-A1", 20, "v1.5");

            Console.WriteLine("=== Original Industrial Robot ===");
            industrialRobot.DisplayInfo();
            industrialRobot.IndustrialTask();

            Console.WriteLine();

            // Clone Industrial Robot
            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialRobot.Clone();

            clonedIndustrialRobot.ModelName = "IndustrialBot-A2";
            clonedIndustrialRobot.BatteryCapacity = 25;
            clonedIndustrialRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("=== Cloned Industrial Robot ===");
            clonedIndustrialRobot.DisplayInfo();
            clonedIndustrialRobot.IndustrialTask();

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            // Create the original Entertainment Robot
            EntertainmentRobot entertainmentRobot =
                new EntertainmentRobot("FunBot-E1", 8, "v1.0");

            Console.WriteLine("=== Original Entertainment Robot ===");
            entertainmentRobot.DisplayInfo();
            entertainmentRobot.EntertainmentFeature();

            Console.WriteLine();

            // Clone Entertainment Robot
            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentRobot.Clone();

            clonedEntertainmentRobot.ModelName = "FunBot-E2";
            clonedEntertainmentRobot.BatteryCapacity = 12;
            clonedEntertainmentRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("=== Cloned Entertainment Robot ===");
            clonedEntertainmentRobot.DisplayInfo();
            clonedEntertainmentRobot.EntertainmentFeature();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}