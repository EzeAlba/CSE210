using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?: ");
        string grade_str = Console.ReadLine();
        int grade = int.Parse(grade_str);
        string letter = "";
        string sign = "";

        if(grade >= 90){
            letter = "A";
            if (grade >= 97)
            {
              sign = "";  
            }
            else if (grade < 93)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if(grade >= 80){
            letter = "B";
            if (grade >= 87)
            {
              sign = "+";  
            }
            else if (grade < 83)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if(grade >= 70){
            letter = "C";
            if (grade >= 77)
            {
              sign = "+";  
            }
            else if (grade < 73)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if(grade >= 60){
            letter = "D";
            if (grade >= 67)
            {
              sign = "+";  
            }
            else if (grade < 63)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else{
            letter = "F";
            }

        Console.WriteLine($"Your grade is {letter}{sign}");



    }
}