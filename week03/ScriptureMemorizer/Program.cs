// Exceeding Requirements (Creativity):
//  Scripture Library from File: Loads multiple scriptures from an external "scriptures.txt" file and selects one at random each run.
// Punctuation Preservation: Keeps commas, periods, and semicolons intact when hiding words, ensuring the scripture's readability and flow.
// Reset enter: Allows users to reset the scripture to its original state by typing "reset", enabling repeated practice without restarting the program.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = LoadScriptures("scriptures.txt");
        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue, type 'reset' to start over, or type 'quit' to finish:");

            userInput = Console.ReadLine().Trim();

            if (userInput.ToLower() == "reset")
            {
                scripture.Reset();
            }
            else if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words hidden! Congratulations! You have memorized the scripture!");
        }
    }

    static List<Scripture> LoadScriptures(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        string fullPath = File.Exists(filePath)
            ? filePath
            : Path.Combine(AppContext.BaseDirectory, filePath);

        if (File.Exists(fullPath))
        {
            string[] lines = File.ReadAllLines(fullPath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('|');
                if (parts.Length == 4)
                {
                    Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                    scriptures.Add(new Scripture(reference, parts[3]));
                }
                else if (parts.Length == 5)
                {
                    Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                    scriptures.Add(new Scripture(reference, parts[4]));
                }
            }
        }

        if (scriptures.Count == 0)
        {
            Reference fallbackRef = new Reference("Proverbs", 3, 5, 6);
            scriptures.Add(new Scripture(fallbackRef, "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        }

        return scriptures;
    }
}