using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine("******");
        Assignment test1 = new Assignment("Colby", "Calculus");
        Console.WriteLine(test1.GetSummary());
        Console.WriteLine("******");
        MathAssignment test2 = new MathAssignment("Graciela", "Algebra", "Section 2.1", "7-9");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());
        Console.WriteLine("******");
        WritingAssignment test3 = new WritingAssignment("Graciela", "Creative Writing", "The Great Escape");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());

    }
}