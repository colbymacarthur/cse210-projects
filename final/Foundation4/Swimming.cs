using System;

public class Swimming : Activity
{
    public override double CalculateDistance(double laps)
    {
        _distance = laps * 50 / 1000 * .62;
        return _distance; 
    }
    public override void NewActivity()
    {
        string date = DateTime.Now.ToString("d MMMM");
        string activity = "Swimming";
        Console.WriteLine("How many laps did you swim?");
        double swimLaps = double.Parse(Console.ReadLine());
        double swimDistance = CalculateDistance(swimLaps);
        Console.WriteLine("How long did it take?");
        double swimTime = double.Parse(Console.ReadLine());
        double swimSpeed = CalculateSpeed(swimDistance, swimTime);
        double swimPace = CalculatePace(swimSpeed);
        Console.WriteLine("");
        GetSummary(activity, date, swimTime, swimDistance, swimSpeed, swimPace);
        Console.WriteLine("\n\nPress any button to continue.");
        Console.ReadKey();
    }
}