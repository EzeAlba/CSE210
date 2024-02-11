using System;

public class BreathingActivity:Activity
{

    public BreathingActivity(int duration) : base("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breath.", duration)
    {
        _duration = duration;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("Get ready...");
        ShowSpinner(5);
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
        
            Console.Write("\nBreath in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            if (DateTime.Now >= endTime)
                break;

            Console.Write("\nBreath out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            if (DateTime.Now >= endTime)
            break;
        }
        Console.WriteLine("\n");
        DisplayEndingMessage();

    }

}