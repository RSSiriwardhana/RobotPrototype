namespace RobotPrototype
{
    public class EntertainmentRobot : Robot
    {
        public EntertainmentRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion)
            : base(modelName, batteryCapacity, softwareVersion)
        {
        }

        public void EntertainmentFeature()
        {
            Console.WriteLine("Entertainment Robot is interacting with people.");
        }

        public override Robot Clone()
        {
            return new EntertainmentRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion);
        }
    }
}