using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userPercentage = Console.ReadLine();
        int percent = int.Parse(userPercentage);
        string grade = "";
        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        string sign = "";
        if (percent % 10 > 7)
        {
            sign = "+";
        }
        else if (percent % 10 < 3)
        {
            sign = "-";
        }
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations you passed the class");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass the class. Please try harder next time.");

        }
        Console.WriteLine($"You got a {grade}{sign}");

    }
}