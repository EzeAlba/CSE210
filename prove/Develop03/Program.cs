using System;
<<<<<<< HEAD
//Exceeds the requirements because I added a new clase that stores different scriptures according to the user selection.
=======
//Exceeds the requirements because I added a new class "Library.cs" that stores different scriptures according to the user selection.
>>>>>>> 4cd34c72a01ccf8821ce4a33f7c546f539b4eb77
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Please select a scripture from the list: ");
        Console.WriteLine("1. Proverbs 3:5-6");
        Console.WriteLine("2. 1 Nephi 3:7");
        Console.WriteLine("3. Alma 37:37");
        Console.WriteLine("4. 2 Nephi 31:5-6");
        int option = int.Parse(Console.ReadLine());
        Library selection = new Library();
        selection.SetScripture(option);


        Reference choice = new Reference(selection.GetBook(), selection.GetChapter(), selection.GetStartVerse(), selection.GetEndVerse());
        Scripture scripture = new Scripture(choice,selection.GetScruptureText());
 
        
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
