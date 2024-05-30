using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetUserList()
    {
        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Enter an item (press Enter to submit, continue until time runs out):");
            foreach (var item in list)
            {
                Console.WriteLine($"- {item}");
            }
            Console.Write("Enter an item: ");
            string newItem = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                list.Add(newItem);
            }
        }
        return list;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(5);
        Console.Clear();
        List<string> items = GetUserList();
        Console.Clear();
        Console.WriteLine($"You listed {items.Count} items:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item}");
        }
        DisplayEndingMessage();
    }
}