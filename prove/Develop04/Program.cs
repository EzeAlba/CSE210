using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
         while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start reflecting Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("How Long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity(duration);
                breathing.Run();
                Console.Clear();
            }
            else if (choice == "2")
            {
                Console.Write("How Long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity(duration);
                reflecting.Run();
                Console.Clear();
            }
            else if (choice == "3")
            {
                Console.Write("How Long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                Console.Clear();
                ListingActivity listing = new ListingActivity(duration);
                listing.Run();
                Console.Clear();
            }
            else if (choice == "4")
            {
                break;
            }
            else 
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.\n");
                Console.Clear();
            }
        }
    }
}