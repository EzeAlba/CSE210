using System;
using System.Collections.Generic;
using System.IO;
public class SimpleGoal:Goal
{
    protected bool _isComplete;

    
    public SimpleGoal(string name,string description, string points) : base (name,description,points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_isComplete}";
    }
}