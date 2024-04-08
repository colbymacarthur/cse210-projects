using System;

public class OutdoorGathering : Event
{
    // Attributes
    private string _weather;

    // Constructors
    public OutdoorGathering(string name, string description, string date, string time, string address, string weather)
    {
        _eventTitle = name;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weather = weather;
    }

    // Methods
    public void FullDetails()
    {
        Console.WriteLine("Standard desciption");
        Console.WriteLine($"Event name: {_eventTitle}");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Weather Forcast: {_weather}");
        Console.WriteLine($"Location: {_address}\n");
    }
}