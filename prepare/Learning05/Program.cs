using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Creates list to cycle through
        List<Shape> shapes = new List<Shape>();
        // new square shape
        Square square = new Square(5, "Blue");
        shapes.Add(square);
        // new circle
        Circle circle = new Circle(5, "Yellow");
        shapes.Add(circle);
        // new retangle
        Rectangle rectangle = new Rectangle(5, 6, "Red");
        shapes.Add(rectangle);
        // cycle through each item in list
        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}