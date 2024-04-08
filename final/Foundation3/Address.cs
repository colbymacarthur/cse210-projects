using System;

public class Address
{
    // Attributes
    private string _venueName;
    private string _address;
    private string _cityANDstate;


    // Constructors

    // Methods
    
    public string EventAddress(List<string> venueData, string venue)
    {
        foreach (string v in venueData)
            {   // Cycle through venues
                string[] parts = v.Split('|');
                _venueName = parts[0].Trim();
                _address = parts[1].Trim();
                _cityANDstate = parts[2].Trim();
                if (_venueName == venue)
                {
                    return $"{_venueName}, {_address}, {_cityANDstate}";
                }
            }
        return "Venue not found";
    }
}