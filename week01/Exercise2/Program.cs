using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string gradeString = Console.ReadLine();
        int gradeInt = int.Parse(gradeString);
        string letter = "";
        if (gradeInt >= 70)
            if (gradeInt >= 90)
            {
                letter = "A";
            }
            else if (gradeInt >= 80)
            {
                letter = "B";
            }
            else if (gradeInt >= 70)
            {
                letter = "C";
            }
        if (gradeInt < 70)
            if (gradeInt >= 60)
            {
                letter = "D";
            }
            else if (gradeInt < 60)
            {
                letter = "F";
            }
        if (gradeInt >= 70 && letter == "A")
        {
            Console.WriteLine($"Congratulation! You passed the coruse with an {letter}!");
        }
        else if (gradeInt >= 70 && letter != "A")
        {
            Console.WriteLine($"Congratulation! You passed the coruse with a {letter}!");
        }
        else if (gradeInt < 70)
        {
            Console.WriteLine($"Your grade is a {letter}. The next semester will be better!");
        }
    }
}