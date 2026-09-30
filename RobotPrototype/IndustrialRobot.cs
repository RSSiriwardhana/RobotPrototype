namespace RobotPrototype
{
    public class IndustrialRobot : Robot
    {
        public IndustrialRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion)
            : base(modelName, batteryCapacity, softwareVersion)
        {
        }

        public void IndustrialTask()
        {
            Console.WriteLine("Industrial Robot is performing welding and assembly tasks.");
        }

        public override Robot Clone()
        {
            return new IndustrialRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion);
        }
    }
}