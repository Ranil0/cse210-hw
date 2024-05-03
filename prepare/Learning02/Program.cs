using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to the Journal program!");

        List<Tuple<DateTime, string>> journalEntries = new List<Tuple<DateTime, string>>();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter your journal entry: ");
                    string entry = Console.ReadLine();
                    journalEntries.Add(new Tuple<DateTime, string>(DateTime.Now, entry));
                    Console.WriteLine("Entry added successfully!");
                    break;
                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    foreach (var journalEntry in journalEntries)
                    {
                        Console.WriteLine($"{journalEntry.Item1}: {journalEntry.Item2}");
                    }
                    break;
                case "3":
                    Console.Write("Enter the file path to load: ");
                    string filePathLoad = Console.ReadLine();
                    if (File.Exists(filePathLoad))
                    {
                        journalEntries = new List<Tuple<DateTime, string>>();
                        string[] lines = File.ReadAllLines(filePathLoad);
                        foreach (var line in lines)
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
                            {
                                journalEntries.Add(new Tuple<DateTime, string>(date, parts[1]));
                            }
                        }
                        Console.WriteLine("Entries loaded successfully!");
                    }
                    else
                    {
                        Console.WriteLine("File not found!");
                    }
                    break;
                case "4":
                    Console.Write("Enter the file path to save: ");
                    string filePathSave = Console.ReadLine();
                    List<string> linesToSave = new List<string>();
                    foreach (var journalEntry in journalEntries)
                    {
                        linesToSave.Add($"{journalEntry.Item1}|{journalEntry.Item2}");
                    }
                    File.WriteAllLines(filePathSave, linesToSave);
                    Console.WriteLine("Entries saved successfully!");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Journal program!");
    }
}
