using System;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    // Attributes
    private string _shortName;
    private string _description;
    private string _points;

    // Constructors
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Getters and Setters

    // Methods
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetails()
    {
        string test = "I'm trying";
        return test;
    }
    public abstract string GetStringRepresentation();
}