namespace RobotPrototype
{
    public abstract class Robot
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }

        public Robot(string modelName, double batteryCapacity, string softwareVersion)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
        }

        public abstract Robot Clone();

        public void DisplayInfo()
        {
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
        }
    }
}