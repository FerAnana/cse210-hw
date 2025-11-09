using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator randomPrompt = new PromptGenerator();
        
        string choice = "";

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("\nSelect one: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(theJournal, randomPrompt);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    SaveJournal(theJournal);
                    break;
                case "4":
                    LoadJournal(theJournal);
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter a number from 1 to 5.");
                    break;
            }

        } while (choice != "5");
    }

    static void WriteNewEntry(Journal journal, PromptGenerator generator)
    {
        // Get a random prompt
        string randomPrompt = generator.GetRandomPrompt();
        
        // Display the prompt to the user
        Console.WriteLine($"\n{randomPrompt}");
        Console.Write("> ");

        // Get the user's response
        string responseText = Console.ReadLine();

        // 4. Create a new Entry object
        Entry newEntry = new Entry();
        newEntry._promptText = randomPrompt;
        newEntry._entryText = responseText;

        // 5. Add the new entry to the journal
        journal.AddEntry(newEntry);
    }
    static void SaveJournal(Journal journal)
    {
        Console.Write("\nEnter the filename to save your journal (example: myjournal.txt): ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("\nPlease enter the filename to load the journal from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}