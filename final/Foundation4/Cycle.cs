using System;

public class Cycle : Activity
{
    public override double CalculateDistance(double speedtime)
    {
        _distance = speedtime / 60;
        return _distance;
    }
    public override void NewActivity()
    {
        string date = DateTime.Now.ToString("d MMMM");
        string activity = "Cycling";
        Console.WriteLine("What was your average speed (mph)?");
        double cycleSpeed = double.Parse(Console.ReadLine());
        Console.WriteLine("How long did you ride for?");
        double cycleTime = double.Parse(Console.ReadLine());
        double cycleDistance = CalculateDistance(cycleSpeed * cycleTime);
        double cyclePace = CalculatePace(cycleSpeed);
        Console.WriteLine("");
        GetSummary(activity, date, cycleTime, cycleDistance, cycleSpeed, cyclePace);
        Console.WriteLine("\n\nPress any button to continue.");
        Console.ReadKey();
    }
}