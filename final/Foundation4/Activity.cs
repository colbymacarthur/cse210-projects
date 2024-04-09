using System;

public abstract class Activity
{
    private string _date;
    private double _time;
    protected double _distance;
    protected double _speed;
    protected double _pace;

    public double CalculateSpeed(double distance, double time)
    {
        _speed = distance / time * 60;
        return _speed;
    }
    public virtual double CalculateDistance(double speed)
    {
        return 1;
    }
    public double CalculatePace(double speed)
    {
        _pace = 60 / speed;
        return _pace;
    }
    public void GetSummary(string excercise, string date, double time, double distance, double speed, double pace)
    {
        _time = time;
        _date = date;
        Console.WriteLine($"{_date} {excercise} {_time} min");
        Console.WriteLine($"Distance: {distance} miles");
        Console.WriteLine($"Speed: {speed} mph");
        Console.WriteLine($"Pace: {pace} min per mile");
    }
    
    public abstract void NewActivity();
}