using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        // Create a list to store activities
        List<Activity> activities = new List<Activity>();

        // Add some activities
        activities.Add(new Running(DateTime.Now, 30, 3.0));
        activities.Add(new StationaryBicycle(DateTime.Now, 45, 15.0));
        activities.Add(new SwimmingLapPool(DateTime.Now, 60, 20));

        // Display summaries of activities
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}