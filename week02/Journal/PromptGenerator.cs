using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Member variables (Attributes)
    public List<string> _prompts = new List<string>
    {
        "1.How was my yesterday?",
        "2.What was the best part of my day?",
        "3.What was the worst part of my day?",
        "4.Who was the most interesting person I interacted with today?",
        "5.What did I learn yesterday?",
        "6.How did I see the hand of the Lord in my life today?",
        "7.What was the strongest emotion I felt today?",
        "8.If I had one thing I could do over today, what would it be?",
        "9.Where was I today? What was I doing? What did I see? What did I hear? What did I smell?",
        "10.What was the most beautiful thing I saw today?",
    };

    // Requires a return statement
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}