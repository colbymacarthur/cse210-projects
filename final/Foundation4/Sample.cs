using System;

class Sample : Activity
{
    public void Example()
    {
        string date = DateTime.Now.ToString("d MMMM");
        Console.WriteLine("\n---Running example---");
        string rAct = "Running";
        Running run =  new Running();
        double runDistance = 4;
        double runTime = 25;
        double runSpeed = run.CalculateSpeed(runDistance, runTime);
        double runPace = run.CalculatePace(runSpeed);
        run.GetSummary(rAct, date, runTime, runDistance, runSpeed, runPace);

        Console.WriteLine("\n---Swimming example---");
        string sAct = "Swimming";
        Swimming swim = new Swimming();
        double swimLaps = 5;
        double swimDistance = swim.CalculateDistance(swimLaps);
        double swimTime = 10;
        double swimSpeed = swim.CalculateSpeed(swimDistance, swimTime);
        double swimPace = swim.CalculatePace(swimSpeed);
        swim.GetSummary(sAct, date, swimTime, swimDistance, swimSpeed, swimPace);

        Console.WriteLine("\n---Cycling example---");
        string cAct = "Swimming";
        Cycle cycle = new Cycle();
        double cycleSpeed = 20;
        double cycleTime = 40;
        double cycleDistance = cycle.CalculateDistance(cycleSpeed * cycleTime);
        double cyclePace = cycle.CalculatePace(cycleSpeed);
        cycle.GetSummary(cAct, date, cycleTime, cycleDistance, cycleSpeed, cyclePace);
    }
    public override void NewActivity()
    {
        
    }
}