using System;

public class BreathingActivity : Activity
{
    // No Variables

    // Constructs
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax as you focus on your breathing.";
    }

    // Method
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage(_name, _description);
        Console.Clear();
        Console.WriteLine("Get ready:");
        ShowSpinner(5);
        Rounds(_duration);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public void Rounds(int duration)
    {
        int rounds = duration / 10000;
        for (int i = rounds; i>0; i--)
        {
            Console.Clear();
            Console.WriteLine("OK lets get started \n ");
            Console.WriteLine($"Rounds left {i}\n");
            Console.WriteLine($"Breath in");
            ShowCountDown(4);
            Console.WriteLine("Breath out");
            ShowCountDown(6);
        }
    }
}