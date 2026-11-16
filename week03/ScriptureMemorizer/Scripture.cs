
using System;
using System.Collections.Generic;

public class Scripture
{
    // Private attributes
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Convert the scripture text into Word objects
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Hide a specified number of random words
    public void HideRandomWords(int numberToHide)
    {
        // Implementation will be added later
    }

    // Return the scripture display text
    public string GetDisplayText()
    {
        // Implementation will be added later
        return "";
    }

    // Check whether every word is hidden
    public bool IsCompletelyHidden()
    {
        // Implementation will be added later
        return false;
    }
}
