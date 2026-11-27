using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

public Activity(string name, string description)
{
    _name = name;
    _description = description;
}

public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session?");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("please enter a valid positive number of seconds: ");
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(4);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        String[] animationStrings = {"|", "/", "_", "\\"};

        for (int i = 0; i < seconds * 4; i++)
        {
             Console.Write(animationStrings[i % 4]);
          Thread.Sleep(250);
          Console.Write("\b \b");
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}