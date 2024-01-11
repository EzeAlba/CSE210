using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess;
        int count = 0;
        
       do{
            Console.WriteLine("What is your guess?: ");
            string guess_str = Console.ReadLine();
            guess = int.Parse(guess_str);
            count++;
    
            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You made {count} guesses!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
        }
        while(guess != number);

        }
}