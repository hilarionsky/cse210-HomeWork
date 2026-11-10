using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Holds the collection of Entry objects
    public List<Entry> _entries = new List<Entry>();

    // Adds a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Prints every entry stored in memory
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves the entries to a text file using "|" separator
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._location}|{entry._mood}");
            }
        }
    }

    // Loads entries into memory from a text file
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];
            loadedEntry._location = parts[3];
            loadedEntry._mood = parts[4];

            _entries.Add(loadedEntry);
        }
    }
}