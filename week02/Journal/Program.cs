using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        string userChoice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        // Loop until the user chooses to quit
        while (userChoice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Entry newEntry = new Entry();
                
                Console.Write("Where are you? ");
                newEntry._location = Console.ReadLine();
                
                Console.Write("Are you relaxed? ");
                newEntry._mood = Console.ReadLine();

                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {newEntry._promptText}");
                
                Console.Write("Your response > ");
                newEntry._entryText = Console.ReadLine();
                
                newEntry._date = DateTime.Now.ToShortDateString();

                theJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("\n--- Journal Entries ---");
                theJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("\nWhat is the filename? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully!");
            }
            else if (userChoice == "4")
            {
                Console.Write("\nWhat is the filename? ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully!");
            }
        }
        Console.WriteLine("\nGoodbye!");
    }
}