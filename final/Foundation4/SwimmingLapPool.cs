using System;
using System.Collections.Generic;

public class SwimmingLapPool : Activity
{
    private int _laps;

    public SwimmingLapPool(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_length / 60.0);
    }

    public override double GetPace()
    {
        return _length / (_laps * 50 / 1000.0); 
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Laps: {_laps}, Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}