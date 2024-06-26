using System;

public class Lecture : Event
{
    // Attributes
    private string _speaker;
    private string _capacity;

    // Constructors
    public Lecture(string name, string description, string date, string time, string address, string speaker, string capacity)
    {
        _eventTitle = name;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speaker = speaker;
        _capacity = capacity;
    }

    // Methods
    public void FullDetails()
    {
        Console.WriteLine("Standard desciption");
        Console.WriteLine($"Event name: {_eventTitle}");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine($"Location: {_address}\n");
    }
}