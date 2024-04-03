using System;

public class Customer
{
    // Attributes
    private List<string> _customerData = new List<string>();

    // Methods
    public List<string> LoadCustomers()
    {
        string filename = "Customers.txt";
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _customerData.Add(line);
                }
                Console.WriteLine("Customer data loaded successfully\n");
                return _customerData;
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No customer data loaded");
            return _customerData;
        }
    }
}