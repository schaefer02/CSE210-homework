using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string  gradeFromUser = Console.ReadLine();
        int x = int.Parse(gradeFromUser);

        string grade = "";
        

        if (x >= 90)
        {
            grade = "A";
        }
        else if (x >= 80)
        {
            grade = "B";
        }
        else if (x >= 70)
        {
            grade = "C";
        }
        else if (x >= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is: {grade}");

        if (x > 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}