using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _Count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are the personal strength of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "How are your personal heroes?"
    };

    private List<string> _unusedPrompts;
    private Random _random = new Random();

    public ListingActivity() : base(
        "ListingActivity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();
        _Count = items.Count;

        Console.WriteLine($"You listed {_Count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        return prompt;
    }

    private List<string> GetListFromUser()
{
    List<string> userList = new List<string>();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    string currentInput = "";

    Console.Write("> ");

    while (DateTime.Now < endTime)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                if (!string.IsNullOrWhiteSpace(currentInput))
                {
                    userList.Add(currentInput);
                }
                currentInput = "";
                Console.Write("> ");
            }
            else if (key.Key == ConsoleKey.Backspace && currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                Console.Write("\b \b");
            }
            else if (!char.IsControl(key.KeyChar))
            {
                currentInput += key.KeyChar;
                Console.Write(key.KeyChar);
            }
        }
    }

    Console.WriteLine();
    return userList;
}

}