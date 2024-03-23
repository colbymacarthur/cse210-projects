using System;

public class ListingActivity : Activity
{
    // Attributes
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "When have you felt the Holy Ghost in this month?",
        "When did you know that God love you?" ,
        "When you felt a deep spiritual connection or sense of divine presence in your life?",
        "How has your faith or spirituality played a role in providing comfort or guidance during challenging times in your life?",
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructs
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you see all the good things in your life my making a list.";
    
    }

    // Methods
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage(_name, _description);
        Console.Clear();
        Console.WriteLine("Get ready:");
        ShowSpinner(5);
        Console.WriteLine($"{GetRandomPrompt()}");
        ShowSpinner(10);
        GetListFromUser(_duration);
        Console.WriteLine($"Well done you listed {_count} things");
        ShowSpinner(5);
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
    public List<string> GetListFromUser(int duration)
    {
        List<string> answers = new List<string>();
        DateTime endTime = DateTime.Now.AddMilliseconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter your answer (or press Enter to skip):");
            string answer = Console.ReadLine();

            if (!string.IsNullOrEmpty(answer))
            {
                answers.Add(answer);
                _count++;
            }
        }
        return answers;   
    }
}