using System;

public class Reception : Event
{
    // Attributes
    private string _email;

    // Constructors
    public Reception(string name, string description, string date, string time, string address, string email)
    {
        _eventTitle = name;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _email = email;
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
        Console.WriteLine($"RSVP {_email}");
        Console.WriteLine($"Location: {_address}\n");
    }
}