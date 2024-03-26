using System;
using System.Drawing;

class Rectangle : Shape
{
    // Attributes
    private double _length;
    private double _width;

    // Constructs
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Getters and Setters

    // Methods
    public override double GetArea()
    {
        return _length * _width;
    }
}