using System;
using System.Collections.Generic;
using System.IO;
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    //constructor
    public Goal(string name,string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"CHECKBOX {_shortName} : {_description}";
    }

    public abstract string GetStringRepresentation();
 
}