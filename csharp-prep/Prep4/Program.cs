using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> number_list = new List<int>();
        int NewNum;
        int sum = 0;
        float average;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.WriteLine("Enter number:");
            string NewNum_str = Console.ReadLine();
            NewNum = int.Parse(NewNum_str);

            if(NewNum != 0)
            {
                number_list.Add(NewNum);
            }
        }
        while (NewNum != 0);

        foreach(int number in number_list)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        average = ((float)sum) / number_list.Count;
        Console.WriteLine($"The average is: {average}");

        int max = number_list.Max();
        Console.WriteLine($"The max number is {max}.");
        }
    }
