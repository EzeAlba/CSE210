using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(duration);
        // Bucle para iterar durante el tiempo deseado

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
    }
}