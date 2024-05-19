using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>() 
    {
        "What did I learn today and how can I apply it in my life?",
        "What act of kindness did I experience or perform today?",
        "What challenge did I face today and how did I overcome it?",
        "What am I grateful for today and why?",
        "How did I take care of myself today, whether physically, mentally or emotionally?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}