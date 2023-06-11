using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int yourguess = -1;

        while (yourguess != number)
        {
            Console.WriteLine("Guess a number between 1 and 100");
            yourguess = int.Parse(Console.ReadLine());


            if (number > yourguess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < yourguess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("congrats, you guessed it!");
            }
        }
    }
}