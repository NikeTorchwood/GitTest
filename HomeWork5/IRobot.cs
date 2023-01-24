using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    interface IRobot
    {
        public string GetInfo();
        public List<string> GetComponents();
        string GetRobotType()
        {
            return "I am simple robot.";
        }
    }
}
