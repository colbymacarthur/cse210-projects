using System;

public class Product
{
    // Attributes
    private List<string> _productData = new List<string>();

    // Methods
    public List<string> LoadProducts()
    {
        string filename = "Products.txt";
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _productData.Add(line);
                }
                Console.WriteLine("Product data loaded successfully\n");
                return _productData;
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No data loaded");
            return _productData;
        }
    }
}