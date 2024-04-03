using System;

public class Order
{
    // Attributes
    private List<String> _orders = new List<string>();

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
            string c_customerName = pair[1].Trim();
            string country = pair[5].Trim();
            Address address = new Address();
            Console.WriteLine("Shipping label\n");
            address.ShippingLabel(customerData, c_customerName);
            Console.WriteLine("\nInvoice\nProduct Quantity Item total");
            int total = 0;
            int shipping = address.ShippingCost(country);
            foreach (string o in orderData)
            {
                string[] parts = o.Split('|');
                string customerName = parts[0].Trim();
                string orderProduct = parts[1].Trim();
                int quantity = int.Parse(parts[2].Trim());
                if (c_customerName == customerName)
                {
                    foreach (string p in productData)
                    {
                        string[] sets = p.Split('|');
                        string productName = sets[1].Trim();
                        int price = int.Parse(sets[2].Trim());
                        if (productName == orderProduct)
                        {
                            int itemTotal = price * quantity;
                            total += itemTotal;
                            Console.WriteLine($"{orderProduct}: {quantity} -- ${itemTotal}.00");
                        }
                    }
                }
            }
            Console.WriteLine($"Subtotal ${total}.00");
            Console.WriteLine($"Shipping cost: {shipping}");
            Console.WriteLine($"Total due ${total + shipping}.00");
            Console.WriteLine("\n------------------\n");
        }
    }
}