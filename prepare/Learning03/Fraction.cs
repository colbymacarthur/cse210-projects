using System;
using System.Dynamic;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public int Numerator
    {
        get 
        { 
            return _numerator;
        }
        set 
        { 
            _numerator = value;
        }
    }
    public int Denominator
    {
        get
        {
            return _denominator;
        }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator can't be zero");
            }
            _denominator = value;
        }
    }

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());               }
    public Fraction(int numerator, int denominator )
    {
        _numerator = numerator;
        _denominator = denominator;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());    }
    public string GetFractionString()
    {
        string normalFraction = $"{_numerator}/{_denominator}";
        return normalFraction;
    }
    public double GetDecimalValue()
    {
        double decimalFraction = (double)_numerator / (double)_denominator;
        return decimalFraction;
    }
}