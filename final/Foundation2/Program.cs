using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Make customer database
        Customer customers = new Customer();
        List<string> customerData = customers.LoadCustomers();
        // Make product database
        Product products = new Product();
        List<string> productData = products.LoadProducts();
        // Make product database
        Order orders = new Order();
        List<string> orderData = orders.LoadOrders();
        // Generate labels
        orders.PackingLabel(customerData, orderData, productData);
    }
}