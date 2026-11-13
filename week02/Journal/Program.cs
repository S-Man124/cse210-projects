
using System;
using System.IO;

// CSE210 W02 Journal Project - Exceeding Requirements
//
// Creativity enhancements:
// 1. Added JSON file support using System.Text.Json.
// 2. Users can save and load both .txt and .json files
//    without changing the original five-option menu.
// 3. Added file-existence checks and exception handling
//    to prevent crashes when loading invalid or missing files.
// 4. Added an empty-journal message and filename validation.
//
// These enhancements improve data storage flexibility,
// usability, and reliability.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                {
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    Console.Write("> ");

                    string response = Console.ReadLine() ?? "";
                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry();

                    newEntry._date = date;
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;

                    journal.AddEntry(newEntry);

                    Console.WriteLine("Entry added to journal!");
                    break;
                }

                case "2":
                {
                    journal.DisplayAll();
                    break;
                }

                case "3":
                {
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(loadFilename))
                    {
                        Console.WriteLine("Please enter a valid filename.");
                        break;
                    }

                    if (!File.Exists(loadFilename))
                    {
                        Console.WriteLine(
                            "File not found. Please check the filename and try again."
                        );
                        break;
                    }

                    try
                    {
                        if (loadFilename.EndsWith(
                            ".json",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            journal.LoadFromJson(loadFilename);
                        }
                        else
                        {
                            journal.LoadFromFile(loadFilename);
                        }

                        Console.WriteLine("Journal loaded successfully!");
                    }
                    catch (Exception ex) when (
                        ex is IOException ||
                        ex is UnauthorizedAccessException ||
                        ex is FormatException ||
                        ex is System.Text.Json.JsonException ||
                        ex is ArgumentException)
                    {
                        Console.WriteLine(
                            $"Unable to load journal: {ex.Message}"
                        );
                    }

                    break;
                }

                case "4":
                {
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(saveFilename))
                    {
                        Console.WriteLine("Please enter a valid filename.");
                        break;
                    }

                    try
                    {
                        if (saveFilename.EndsWith(
                            ".json",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            journal.SaveToJson(saveFilename);
                        }
                        else
                        {
                            journal.SaveToFile(saveFilename);
                        }

                        Console.WriteLine("Journal saved successfully!");
                    }
                    catch (Exception ex) when (
                        ex is IOException ||
                        ex is UnauthorizedAccessException ||
                        ex is ArgumentException)
                    {
                        Console.WriteLine(
                            $"Unable to save journal: {ex.Message}"
                        );
                    }

                    break;
                }

                case "5":
                {
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                }

                default:
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            }
        }
    }
}
