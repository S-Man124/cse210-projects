#nullable enable


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // Store all journal entries
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all journal entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save journal entries to a text file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}~|~{entry._promptText}~|~{entry._entryText}"
                );
            }
        }
    }

    // Load journal entries from a text file
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split(
                new string[] { "~|~" },
                3,
                StringSplitOptions.None
            );

            if (parts.Length != 3)
            {
                throw new FormatException(
                    "The journal file contains an invalid entry."
                );
            }

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            loadedEntries.Add(entry);
        }

        // Replace existing entries only after loading succeeds
        _entries = loadedEntries;
    }

    // Save journal entries in JSON format
    public void SaveToJson(string filename)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true,
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(_entries, options);

        File.WriteAllText(filename, json);
    }

    // Load journal entries from a JSON file
    public void LoadFromJson(string filename)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        string json = File.ReadAllText(filename);

        List<Entry>? loadedEntries =
            JsonSerializer.Deserialize<List<Entry>>(json, options);

        if (loadedEntries == null)
        {
            throw new FormatException(
                "The JSON file does not contain a valid journal."
            );
        }

        foreach (Entry entry in loadedEntries)
        {
            if (entry == null)
            {
                throw new FormatException(
                    "The JSON file contains an invalid entry."
                );
            }
        }

        // Replace existing entries after successful loading
        _entries = loadedEntries;
    }
}
