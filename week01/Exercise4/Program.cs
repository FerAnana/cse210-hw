using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int stopAdd = 0;
        int numToAdd;
        int sum = 0;
        int largestNum = 0;
        int avgNum;
        do
        {
            Console.Write("Enter a number [Enter 0 to quit]: ");
            numToAdd = int.Parse(Console.ReadLine());
            if (numToAdd != stopAdd)
            {
                numbers.Add(numToAdd);
            }
        } while (numToAdd != stopAdd);
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        avgNum = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {avgNum}");
        Console.WriteLine($"The largest number is {largestNum}");
    }   
}