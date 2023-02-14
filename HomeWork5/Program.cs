using HomeWork5;

class Program
{
    static void Main()
    {
        var q = new Quadcopter();
        q.Charge();
        IFlyingRobot flyingRobot = q;
        Console.WriteLine(flyingRobot.GetRobotType());
        IRobot robot = q;
        Console.WriteLine(robot.GetRobotType());


    }
}