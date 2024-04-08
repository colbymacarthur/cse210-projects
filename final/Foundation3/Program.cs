using System;

class Program
{
    static void Main(string[] args)
    {
        DataLoader data = new DataLoader();
        List<string> eventData = data.LoadEvents();
        
        Event events = new Event();
        events.SplitData(eventData);
    }
} 