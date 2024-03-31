using System;

public class EternalGoal : Goal
{
    // Attributes

    // Constructors
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    // Getters and Setters

    // Methods
    public override void RecordEvent()
    {

    }
    // fix bool
    public override bool IsComplete()
    {
        return true;
    }
    // fix string
    public override string GetStringRepresentation()
    {
        string test2 = "one step closer";
        return test2;
    }
}