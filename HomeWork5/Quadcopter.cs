using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Quadcopter : IChargeable, IFlyingRobot
    {
        List<string> _component = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public List<string> GetComponents()
        {
            return _component;
        }

        public string GetInfo()
        {
            return "I am simple robot.";
        }
    }
}
