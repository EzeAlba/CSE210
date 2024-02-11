using System;
using Microsoft.VisualBasic;

public class ListingActivity:Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();
    private List<string> _userInputs = new List<string>();

    public ListingActivity(int duration) : base ("Listing Activity","This activity will help you reflect on good things in your life by having you a list as many things as you can in a certain area.",duration) 
    {
        
    } 

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("Get ready... ");
        ShowSpinner(5);
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _userInputs.Add(input);
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage(); 
    }
    public string GetRandomPrompt()
    {
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("What is one thing you accomplished today that you're proud of?");
        _prompts.Add("How do you feel about your progress towards your long-term goals?");
        _prompts.Add("Describe a recent situation where you had to overcome a challenge. How did you handle it?");
        _prompts.Add("How do you manage stress or difficult emotions when they arise?");
        _prompts.Add("What is one skill or hobby you'd like to develop further? How do you plan to do it?");
        _prompts.Add("Think about a mistake you made recently. What did you learn from it?");
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        string randomString = _prompts[randomIndex];
        return $" --- {randomString} ---";
    }

}