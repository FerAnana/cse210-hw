using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicInt = randomGenerator.Next(1, 100);
        int guessInt;

        do
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guessInt = int.Parse(guessString);
            if (guessInt == magicInt)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guessInt > magicInt)
            {
                Console.WriteLine("Lower.");
            }
            else if (guessInt < magicInt)
            {
                Console.WriteLine("Higher.");
            }
        } while (guessInt != magicInt);
    }
}