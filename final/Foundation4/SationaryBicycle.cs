using System;
using System.Collections.Generic;

public class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * (_length / 60.0);
    }

    public override double GetPace()
    {
        return 60 / _speed; 
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Speed: {_speed} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} min/mile";
    }
}