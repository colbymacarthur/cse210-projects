using System;

public class Running : Activity
{
    public override double CalculateDistance(double distance)
    {
        _distance = distance;
        return _distance;
    }
    public override void NewActivity()
    {
        string date = DateTime.Now.ToString("d MMMM");
        string activity = "Running";
        Console.WriteLine("How many miles did you run?");
        double runDistance = double.Parse(Console.ReadLine());
        Console.WriteLine("How long did it take?");
        double runTime = double.Parse(Console.ReadLine());
        double runSpeed = CalculateSpeed(runDistance, runTime);
        double runPace = CalculatePace(runSpeed);
        Console.WriteLine("");
        GetSummary(activity, date, runTime, runDistance, runSpeed, runPace);
        Console.WriteLine("\n\nPress any button to continue.");
        Console.ReadKey();
    }
}