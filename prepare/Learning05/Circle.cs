using System;
using System.Drawing;

class Circle : Shape
{
    // Attributes
    private double _radius;

    // Constructs
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    // Getters and Setters

    // Methods
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}