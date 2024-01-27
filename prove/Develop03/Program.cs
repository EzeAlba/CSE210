using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        string book = "Proverbs";
        int chapter = 3;
        int startVerse = 5; 
        int endVerse = 6;
        string scripture_text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        Reference proverbs = new Reference(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(proverbs,scripture_text);
 
        
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);

        } while (!scripture.IsCompletelyHidden());
    
    }
}
