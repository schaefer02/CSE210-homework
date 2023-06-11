using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string yourName = AsksUserName();
        int theNumber = AsksTheNumber();
        int numberSquared = SquareNumber(theNumber);
        DisplayAnswer(yourName, numberSquared);
    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string AsksUserName()
    {
        Console.WriteLine("Please write your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int AsksTheNumber()
    {
        Console.Write("please write your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square =number * number;
        return square;
    }
    static void DisplayAnswer(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
        
    }

}