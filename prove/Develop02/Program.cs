using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");

        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Random Prompt: " + randomPrompt);

        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToShortDateString(),
            _promptText = randomPrompt,
            _entryText = "This is my journal entry text."
        };

        myJournal.AddEntry(newEntry);

        myJournal.DisplayAll();

        myJournal.SaveToFile("journal.txt");

        myJournal.LoadFromFile("journal.txt");

        myJournal.DisplayAll();
    }
}