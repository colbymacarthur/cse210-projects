using System;

public class Activity
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;
    public static int _total = 0;

    // Constructors
    public Activity()
    {

    }

    // Methods
    public int DisplayStartingMessage(string _name, string _description)
    {
       Console.Clear();
       Console.WriteLine($"This is the {_name}");
       Console.WriteLine($"{_description} \n");

       Console.WriteLine("How long do you want to do this activity? ");
        bool activity = true;
        while (activity)
        {
            // Clear and write menu
            Console.WriteLine("1. 30 seconds");
            Console.WriteLine("2. 1 min");
            Console.WriteLine("3. 2 min");
            Console.WriteLine("4. 5 min");
            Console.WriteLine("Please a select an option: ");
             // Selector
            int selection = int.Parse(Console.ReadLine());
            _duration = GetDuration(selection);
            _total += _duration;
           
            activity = false;
        }
        return _duration;
    }
   
    public int GetDuration(int selection)
    {
        switch (selection)
        {
            case 1:
                return 30000;
            case 2:
                return 60000;
            case 3:
                return 120000;
            case 4:
                return 300000;
            default:
                Console.WriteLine("Invalid option");
                return 0;
        }
    }
    public static void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Congratulations keep up the good work");
        int totalMinutes = _total / 60000;
        int totalSeconds = _total % 60000 / 1000;
        Console.WriteLine($"You have done {totalMinutes} minutes and {totalSeconds} seconds of mindfulness today");    }
    public void ShowSpinner(int seconds)
    {
        Console.CursorVisible = false;
        for (int counter = seconds; counter > 0; counter--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            Console.Write("\\");            
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            Console.Write("|");        
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            Console.Write("/");        
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.Write("\b \b\n");
    }
    public void ShowCountDown(int seconds)
    {
        for (int a = seconds; a>0; a--)
            {
                Console.Write(a);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
}