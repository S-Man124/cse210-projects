
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What important lesson did I learn today?",
        "Who made a positive difference in my life today?",
        "What am I most grateful for today?",
        "What challenge did I overcome today?",
        "What could I do better tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
