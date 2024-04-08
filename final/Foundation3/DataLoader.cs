using System;

public class DataLoader
{
    private List<string> _venueData = new List<string>();
    private List<string> _eventData = new List<string>();

    public List<string> LoadVenues()
    {
        string filename = "Venue.txt";
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine();
                string line;
                List<string> venues = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    _venueData.Add(line);
                }
                // Console.WriteLine("Venue data loaded successfully\n******\n");
                return _venueData;
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No Venue data loaded");
            return new List<string>(); // return empty list on error
        }
    }
    public List<string> LoadEvents()
    {
        string filename = "Events.txt";
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine();
                string line;
                List<string> venues = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    _eventData.Add(line);
                }
                Console.Clear();
                Console.WriteLine("Event data loaded successfully");
                return _eventData;
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No Event data loaded");
            return new List<string>(); // return empty list on error
        }
    }
}