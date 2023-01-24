using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    interface IFlyingRobot : IRobot
    {
        new string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
