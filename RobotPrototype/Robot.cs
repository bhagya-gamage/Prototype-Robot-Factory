using System;
using System.Collections.Generic;
using System.Text;

namespace RobotPrototype
{
    public abstract class Robot : RobotPrototype
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }

        protected Robot(string modelName, double batteryCapacity, string softwareVersion)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
        }

        public abstract RobotPrototype Clone();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model Name       : {ModelName}");
            Console.WriteLine($"Battery Capacity : {BatteryCapacity} hours");
            Console.WriteLine($"Software Version  : {SoftwareVersion}");
        }
    }
}
