using System;
using System.Reflection.Metadata.Ecma335;

public class Address
{
    // Attributes
    private string _streetAddress;
    private string _city;
    private string _stateORprovince;
    private string _country;

    // Constructos

    // Methods
    // check if country is USA
    public int ShippingCost(string country)
    {
        if (country == "USA")
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public void ShippingLabel(List<string> customerData, string customer)
    {
        foreach (string c in customerData)
        {
            string[] parts = c.Split('|');
            string customerName = parts[1].Trim();
            string streetAddress = parts[2].Trim();
            string city = parts[3].Trim();
            string stateORprovince = parts[4].Trim();
            string country = parts[5].Trim();
            if (customerName == customer)
            {
                string _address = FormattedAddress(streetAddress, city, stateORprovince, country);
                Console.WriteLine($"{customerName}\n{_address}\n\n* * *");
            }
        }
    }
    // return address formatted on lines
    public string FormattedAddress(string streetAddress, string city, string stateORprovince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateORprovince = stateORprovince;
        _country = country;
        return $"{_streetAddress}\n{_city}, {_stateORprovince}\n{_country}";
    }
}