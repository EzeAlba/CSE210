using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    //private int _goalType;
    //Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    //Start method
    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        // Decide which type of goal to create based on input
        // Add the created goal to the _goals list
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("Which type of goal wuold you like to create?");
        string choice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of your goal? ");
        string description = Console.ReadLine();
        
        Console.WriteLine("What is the amount of points associated with this goal: ");
        string points = Console.ReadLine();


        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetValue = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, targetValue, bonusPoints));
                break;

            default:
                Console.WriteLine("Invalid choice. Goal not added.");
                break;
        }

        Console.WriteLine("Goal Added!\n");
    }

        

    public void RecordEvent()
    {
       // Record an event for the specified goal

    }

    public void SaveGoals()
    {   
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {   
                writer.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    


    public void LoadGoals()
    {
        _goals.Clear();
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
         
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string shortName = parts[0];
                string description = parts[1];
                string points = parts[2];
                int amountCompleted = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);

                if (target > 0)
                {
                    ChecklistGoal goal = new ChecklistGoal(shortName, description, points, target, bonus);
                    goal.RecordEvent(); // Set the completed times
                    _goals.Add(goal);
                }
                else
                {
                    if (amountCompleted > 0)
                    {
                        SimpleGoal goal = new SimpleGoal(shortName, description, points);
                        goal.RecordEvent(); // Mark as completed
                        _goals.Add(goal);
                    }
                    else
                    {
                        if (amountCompleted == 0)
                        {
                            EternalGoal goal = new EternalGoal(shortName, description, points);
                            _goals.Add(goal);
                        }
                    }
                }
            }
        }
    }
}
