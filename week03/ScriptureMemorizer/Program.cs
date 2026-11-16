
using System;
using System.Collections.Generic;

// CSE 210 - Week 03 Scripture Memorizer
//
// EXCEEDING REQUIREMENTS:
// 1. The program contains a library of scriptures and
//    randomly selects one for memorization.
// 2. Only words that are not already hidden are selected.
// 3. The program displays memorization progress as a
//    percentage after each round.

Random random = new Random();

// Create a library of scripture references and texts
List<Scripture> scriptures = new List<Scripture>
{
    new Scripture(
        new Reference("Proverbs", 3, 5, 6),
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
    ),

    new Scripture(
        new Reference("John", 3, 16),
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
    ),

    new Scripture(
        new Reference("1 Nephi", 3, 7),
        "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
    )
};

// Select a random scripture
Scripture scripture = scriptures[random.Next(scriptures.Count)];

// Count the words for progress tracking
int totalWords = scripture.GetTotalWordCount();

while (true)
{
    Console.Clear();

    Console.WriteLine("=== SCRIPTURE MEMORIZER ===");
    Console.WriteLine();

    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();

    int hiddenWords = scripture.GetHiddenWordCount();

    int progress = totalWords > 0
        ? (int)((double)hiddenWords / totalWords * 100)
        : 100;

    Console.WriteLine($"Memorization Progress: {progress}%");
    Console.WriteLine();

    // End when all words have been hidden
    if (scripture.IsCompletelyHidden())
    {
        Console.WriteLine("Congratulations! All words are hidden.");
        break;
    }

    
    Console.Write("Press Enter to hide words or type 'quit': ");
    string input = Console.ReadLine() ?? "";

    if (input.Trim().Equals(
        "quit",
        StringComparison.OrdinalIgnoreCase
    ))
    {
        Console.WriteLine("Memorization session ended.");
        break;
    }

    if (input == "")
    {
        // Hide three visible words per round
        scripture.HideRandomWords(3);
    }
    else
    {
        Console.WriteLine("Invalid input. Press Enter to continue.");
        Console.ReadLine();
    }
}
