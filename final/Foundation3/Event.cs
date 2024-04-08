using System;

public class Event
{
    // Attributes
    protected string _eventTitle;
    protected string _description;
    protected string _eventType;
    protected string _date;
    protected string _time;
    protected string _eventVenue;
    protected string _factor1;
    protected string _factor2;
    protected string _address;

    // Constructors

    // Methods
    // list title, description, date, time, and address
    public void SplitData(List<string> eventData)
    {
        foreach (string e in eventData)
        {   // Cycle through event data
            string[] sets = e.Split('|');
            _eventTitle = sets[0].Trim();
            _eventType = sets[1].Trim();
            _description = sets[2].Trim();
            _date = sets[3].Trim();
            _time = sets[4].Trim();
            _eventVenue = sets[5].Trim();
            _factor1 = sets[6].Trim();
            _factor2 = sets[7].Trim();
            DataLoader venue = new DataLoader();
            List<string> venueData = venue.LoadVenues();
            Address address = new Address();
            _address = address.EventAddress(venueData, _eventVenue);
            // search different event types
            if (_eventType == "Lecture")
            {
                Console.WriteLine($"---Lecture example---");
                Lecture lecture = new Lecture(_eventTitle, _description, _date, _time, _address, _factor1, _factor2);
                lecture.Standard();
                lecture.FullDetails();
                lecture.ShortDescription(_eventType);
            }
            if (_eventType == "Reception")
            {
                Console.WriteLine($"---Reception example---");
                Reception reception = new Reception(_eventTitle, _description, _date, _time, _address, _factor1);
                reception.Standard();
                reception.FullDetails();
                reception.ShortDescription(_eventType);
            }
            if (_eventType == "Outdoor Gathering")
            {
                Console.WriteLine($"---Outdoor Gathering example---");
                OutdoorGathering outdoorGathering = new OutdoorGathering(_eventTitle, _description, _date, _time, _address, _factor1);
                outdoorGathering.Standard();
                outdoorGathering.FullDetails();
                outdoorGathering.ShortDescription(_eventType);
            }
        }
    }
    public void Standard()
    {
        Console.WriteLine("Standard desciption");
        Console.WriteLine($"Event name: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Location: {_address}\n");

    }
    protected void ShortDescription(string _eventType)
    {
        Console.WriteLine("Short description");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Event name: {_eventTitle}");
        Console.WriteLine($"Date: {_date}\n");
    }
}