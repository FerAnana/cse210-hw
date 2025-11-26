using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student = new Assignment("Fernando Añaña", "Programming");
        MathAssignment studentMath = new MathAssignment("Sofia Nievas", "Fractions", "7.3", "8-19");
        WritingAssignment studentWriting = new WritingAssignment("Rodrigo Luna", "European History", "The Causes of World War II");

        Console.WriteLine(student.GetSummary());
        Console.WriteLine($"\n{studentMath.GetHomeworkList()}");
        Console.WriteLine($"\n{studentWriting.GetWritingAssignment()}");
    }
}