using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntryDetails()
    { 
        Console.WriteLine("**************");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_response}");
    }
}