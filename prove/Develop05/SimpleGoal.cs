using System;

public class SimpleGoal : Goal
{
    // Attributes
    private bool _isComplete;

    // Constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
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
    public override string GetStringRepresentation()
    {
        string test1 = "Making progress";
        return test1;
    }
}