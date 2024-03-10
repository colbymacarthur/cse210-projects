using System;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        Console.WriteLine("");

        Console.WriteLine("Welcome back to your daily journal");
        Console.WriteLine("Please confirm your name:");
        journal.Name = Console.ReadLine();
        Console.WriteLine("");
       
       // Start menu
        bool quit = false;
        while (!quit)
        {

            // menu options
            Console.WriteLine("");
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save entries");
            Console.WriteLine("4. Load entries");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();
            Console.WriteLine("");

            switch (choice)
            {
                case "1":
                    // save date, prompt and response
                    string prompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    journal.NewEntry(prompt);
                    break;
                case "2":
                    // Display all entries
                    journal.DisplayEntryDetails();
                    break;
                case "3":
                    // save data to txt file
                    journal.SaveEntries(journal.Name);
                    break;
                case "4":
                    // load data from txt file
                    journal.LoadEntries(journal.Name);
                    break;
                case "5":
                    Console.WriteLine("Thank you for sharing today.");
                    Console.WriteLine("");
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
 
    }
}