using System;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "BreathingActivity",
        "This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int remaining = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);
            if (remaining <= 0) break;

            Console.Write("\n\nBreathe in...");
            ShowCountDown(Math.Min(4, remaining));

            remaining = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);
            if (remaining <= 0) break;

            Console.Write("\nNow breathe out...");
            ShowCountDown(Math.Min(6, remaining));
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }
}