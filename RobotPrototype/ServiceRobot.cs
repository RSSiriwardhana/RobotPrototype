namespace RobotPrototype
{
    public class ServiceRobot : Robot
    {
        public ServiceRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion)
            : base(modelName, batteryCapacity, softwareVersion)
        {
        }

        public void ServiceTask()
        {
            Console.WriteLine("Service Robot is assisting people.");
        }

        public override Robot Clone()
        {
            return new ServiceRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion);
        }
    }
}