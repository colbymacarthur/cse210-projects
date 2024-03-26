using System;
using System.Drawing;
using System.Formats.Asn1;

public abstract class Shape
{
    // Attributes
    private string _color;

    // Constructors
    public Shape(string color)
    {
        _color = color;
    }

    // Getters and Setters
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Methods
    public abstract double GetArea();
}