using System;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    // Attributes
    private List<string> _prompts = new List<string>()
    {
        "When did you last feel accomplished?",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you failed at something.",
        "Think a story about a time when you stepped out of your comfort zone and grew as a result",
        "Think a moment when you faced a tough decision and how you handled it",
        "Recall a story of an obstacle you overcame that made you feel proud",
        "Think of an experience that required you to be resourceful and creative in finding a solution.",
        "Think a difficult task or project you undertook and the lessons you learned from it.",
        "Think about a time when you persevered through adversity and emerged stronger."
    };

    private List<string> _questions = new List<string>()
    {
        "Who helped you at this time?",
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What was your motivation?",
        "Did your resilience and determination grow? ",
        "How did your problem-solving skills come into play? "
    };

    // Constructor
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you remember when you've overcome challenges and empower you to work through your trilas";
    } 

    // Methods
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage(_name, _description);
        Console.Clear();
        Console.WriteLine("Get ready:");
        ShowSpinner(5);
        DisplayPrompt();
        DisplayQuestion(_duration);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int listCount = _prompts.Count;
        int randomIndex = random.Next(listCount);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int listCount = _questions.Count;
        int randomIndex = random.Next(listCount);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n"); 
        Console.WriteLine("When you are ready press any button");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Now ponder these questions.");
        ShowSpinner(5);
    }
    public void DisplayQuestion(int duration)
    {
        Console.Clear();
        int questions = duration / 10000;
        for (int i = questions; i>0; i--)
        {
            Console.WriteLine($"Questions left {i}\n");
            Console.WriteLine($"\n> {GetRandomQuestion()} -- ");
            ShowSpinner(10);
        }
    }
}