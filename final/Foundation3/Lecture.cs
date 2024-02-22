using System;

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker Name: {_speakerName}\nCapacity: {_capacity}";
    }
    
}