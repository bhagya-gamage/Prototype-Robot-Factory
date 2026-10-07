using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace RobotPrototype
{
    public class RobotFactory
    {
        private readonly Dictionary<string, Robot> prototypes;

        public RobotFactory()
        {
            prototypes = new Dictionary<string, Robot>();
        }

        public void RegisterRobot(string key, Robot robot)
        {
            prototypes[key] = robot;
        }

        public Robot CloneRobot(string key)
        {
            if (prototypes.ContainsKey(key))
            {
                return (Robot)prototypes[key].Clone();
            }

            throw new KeyNotFoundException(
                $"Robot prototype '{key}' was not found.");
        }
    }
}
