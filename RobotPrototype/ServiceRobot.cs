using System;
using System.Collections.Generic;
using System.Text;

namespace RobotPrototype
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion,
            string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override RobotPrototype Clone()
        {
            return new ServiceRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                ServiceTask);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Service Robot ===");
            base.DisplayInfo();
            Console.WriteLine($"Service Task      : {ServiceTask}");
        }
    }
}
