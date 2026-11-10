using System;

public class Entry
{
    // Attributes for the journal entry
    public string _date;
    public string _promptText;
    public string _entryText;

    //Creative Attributes
    public string _location;
    public string _mood;

    // Displays the entry in a readable format
    public void Display()
    {
       Console.WriteLine($"Date: {_date} - prompt: {_promptText}");
       Console.WriteLine($"Location: {_location} | Mood: {_mood}");
       Console.WriteLine($"Response: {_entryText}");
       Console.WriteLine();
    }
}