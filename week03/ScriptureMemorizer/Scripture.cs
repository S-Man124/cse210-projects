
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // Private attributes
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Convert scripture text into Word objects
        string[] words = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Hide randomly selected visible words
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words
            .Where(word => !word.IsHidden())
            .ToList();

        int wordsToHide = Math.Min(
            numberToHide,
            visibleWords.Count
        );

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            // Remove selected word to prevent repetition
            visibleWords.RemoveAt(index);
        }
    }

    // Return scripture reference and text
    public string GetDisplayText()
    {
        string scriptureText = string.Join(
            " ",
            _words.Select(word => word.GetDisplayText())
        );

        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    // Check whether every word is hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }


    public int GetTotalWordCount()
    {
        return _words.Count;
    }

    public int GetHiddenWordCount()
    {
        return _words.Count(word => word.IsHidden());
    }   
}
