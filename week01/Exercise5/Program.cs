using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int square = SquareNumber(userNum);
        DisplayResult(userName, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numString = Console.ReadLine();
        int favoriteNum = int.Parse(numString);
        return favoriteNum;
    }

    static int SquareNumber(int getSquare)
    {
        int square = getSquare * getSquare;
        return square;
    }

    static void DisplayResult(string PromptUserName, int SquareNumber)
    {
        Console.WriteLine($"{PromptUserName}, the square of your number is {SquareNumber}");
    }
}