using System;
using System.Drawing;

class Square : Shape
{
    // Attributes
    private double _side;

    // Constructs
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    // Getters and Setters

    // Methods
    public override double GetArea()
    {
        return _side * _side;
    }
}