using System;

class Program
{
    static void Main(string[] args)
    {
        Reference john = new Reference("John", 3, 16);
        string johnText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(john, johnText);

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\n Press 'Enter' to hide more words, or type 'quit' to end the program");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (input == string.Empty)
            {
                scripture.HideRandomWords(3);
            }
        } while (!scripture.IsCompletelyHidden());

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}