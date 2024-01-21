using System;

class Program
{
    static void Main(string[] args)
    {

        int option = 0;
        Journal newJournal = new Journal();
        do
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do:");
            option = int.Parse(Console.ReadLine());

            if(option == 1)//write
            {
                PromptGen newPrompt = new PromptGen();
                string prompt = newPrompt.GetRandomPrompt();


                DateTime theCurrentTime = DateTime.Now;
                //Console.WriteLine("Write your answer:");
                string entryText = Console.ReadLine();

                Entry entry = new Entry(theCurrentTime.ToShortDateString(), prompt, entryText);


                newJournal.AddEntry(entry);
            }

            else if(option == 2)//Display
            {

                DisplayAll(newJournal);

            }

            
            else if(option == 3)//Load
            {
                Console.WriteLine("What is the filename? ");
                string name = Console.ReadLine();
                newJournal.LoadFromFile(name);
            }
            else if(option == 4)//Save
            {
                Console.WriteLine("What is the filename? ");
                string name = Console.ReadLine();
                newJournal.SaveToFile(name);


            }

        } while (option != 5);
        


    }
            private static void DisplayAll(Journal newJournal)
            {
             Console.WriteLine("Journal entries:");
                foreach (var entry  in newJournal.GetEntries())
                {
                    entry.Display();
                }
            }

}