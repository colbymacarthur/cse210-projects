using System;

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    // Constructor
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    // Method
    public string GetHomeworkList()
    {
        return $"{_textBookSection} problems {_problems}";
    }
}

