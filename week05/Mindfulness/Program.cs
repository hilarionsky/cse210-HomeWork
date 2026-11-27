// These are what I added:
// I added session tracking in Program.cs to keep a live log of how many times each activity 
 // was performed during the session
 // Updated ReflectionActivity and ListingActivity so that random prompts and questions are 
 //  never repeated until every item in the list has been used at least once.

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        string choice = "";

        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View session activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathing.Run();
                    breathingCount++;
                    break;
                case "2":
                    reflection.Run();
                    reflectionCount++;
                    break;
                case "3":
                    listing.Run();
                    listingCount++;
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Session Activity Log:");
                    Console.WriteLine($"- Breathing Activity completed: {breathingCount} time(s)");
                    Console.WriteLine($"- Reflection Activity completed: {reflectionCount} time(s)");
                    Console.WriteLine($"- Listing Activity completed: {listingCount} time(s)");
                    Console.WriteLine("\nPress Enter to return to the menu.");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("\nThank you for practicing mindfulness today. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    System.Threading.Thread.Sleep(1500);
                    break;
            }
        }
    }
}