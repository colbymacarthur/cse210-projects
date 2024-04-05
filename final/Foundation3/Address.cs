using System;

public class Address
{
    // Attributes
    private List<string> _venueData = new List<string>();


    // Constructors

    // Methods
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
                Console.WriteLine("Customer data loaded successfully\n");
                return _venueData;
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No customer data loaded");
            return new List<string>(); // return empty list on error
        }
    }
}