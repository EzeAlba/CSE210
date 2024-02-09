using System;
using System.Collections.Generic;
using System.IO;
public class EternalGoal:Goal
{

    
    public EternalGoal(string name,string description, string points) : base (name,description,points)
    {

    }

    public override void RecordEvent()
    {
        //Eternal goals are never marked complete.
    }

    public override bool IsComplete()
    {
         return false;
    }

    public override string GetStringRepresentation()
    {
         return $"{_shortName},{_description},{_points}";
    }
}