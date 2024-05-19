using System;
using System.Collections.Generic;

class Program
{
    static Journal journal = new Journal();
    static PromptGenerator promptGenerator = new PromptGenerator();
    static void Main(string[] args)
    {        
        Console.WriteLine();   
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine();

        String choice;
        do
        {
            Console.WriteLine("Please select one of the following choice: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                WriteEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the name of the file to load: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the name of the file to save: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();         
        }
        while (choice != "5");   
    }

    static void WriteEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Your entry: ");
        string entryText = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            _promptText = prompt,
            _entryText = entryText
        };

        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    static void DisplayEntries()
    {
        journal.DisplayAll();
    }
}