using System;

public class Order
{
    // Attributes
    private List<String> _orders = new List<string>();
    private string _cCustomerName;
    private string _country;
    private int _total;
    private int _shipping;

    // Methods
    public List<string> LoadOrders()
    {
        string filename = "Orders.txt";
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _orders.Add(line);
                }
                Console.WriteLine("Order data loaded successfully\n");
                return _orders;
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No data loaded");
            return _orders;
        }
    }
    public void PackingLabel(List<string> customerData, List<string> orderData, List<string> productData)
    {
        foreach (string c in customerData)
        {
            string[] pair = c.Split('|');
            _cCustomerName = pair[1].Trim();
            _country = pair[5].Trim();
            Address address = new Address();
            Console.WriteLine("Shipping label\n");
            address.ShippingLabel(customerData, _cCustomerName);
            Console.WriteLine("\nInvoice\nProduct Quantity Item total");
            _total = 0;
            _shipping = address.ShippingCost(_country);
            foreach (string o in orderData)
            {
                string[] parts = o.Split('|');
                string customerName = parts[0].Trim();
                string orderProduct = parts[1].Trim();
                int quantity = int.Parse(parts[2].Trim());
                if (_cCustomerName == customerName)
                {
                    foreach (string p in productData)
                    {
                        string[] sets = p.Split('|');
                        string productName = sets[1].Trim();
                        int price = int.Parse(sets[2].Trim());
                        if (productName == orderProduct)
                        {
                            int itemTotal = price * quantity;
                            _total += itemTotal;
                            Console.WriteLine($"{orderProduct}: {quantity} -- ${itemTotal}.00");
                        }
                    }
                }
            }
            Console.WriteLine($"Subtotal ${_total}.00");
            Console.WriteLine($"Shipping cost: ${_shipping}.00");
            Console.WriteLine($"Total due ${_total + _shipping}.00");
            Console.WriteLine("\n------------------\n");
        }
    }
}