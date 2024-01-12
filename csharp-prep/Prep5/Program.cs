using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
   
        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName,squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    } 

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: "); 
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static int SquaredNumber (int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult (string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }



}