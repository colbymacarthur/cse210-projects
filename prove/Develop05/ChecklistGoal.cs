using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructors
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {

    }


    // Getters and Setters

    // Methods
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetails()
    {
        string test3 = "running out of time";
        return test3;
    }
    public override string GetStringRepresentation()
    {
        string test4 = "I'm not going to finish";
        return test4;
    }
}