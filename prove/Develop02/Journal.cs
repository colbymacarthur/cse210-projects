using System;
using System.IO;

public class Journal
{
public string Name { get; set; }
    public List<Entry> _entries { get; set; } = new List<Entry>();

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Entries: {_entries.Count}");

        foreach (Entry response in _entries)
        {
            response.DisplayEntryDetails();
        }
        Console.WriteLine("****");
        Console.WriteLine("");

    } 
    public void NewEntry(string prompt)
    {
        Entry newEntry = new Entry(); // creates new entry and allows me to store it.
        newEntry._date = DateTime.Now.ToString("yyyy-MM-dd"); // save date
        newEntry._prompt = prompt; // save prompt
        newEntry._response = Console.ReadLine(); // save response
        _entries.Add(newEntry); // add to entry class
    }

    public void SaveEntries(string file)
    {
        string filename = Name;
        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            foreach (Entry entry in _entries)
            {
               writer.WriteLine($"{entry._date}, '{entry._prompt}', {entry._response}");
            }
        }
    }

    public void LoadEntries(string file)
    {
        string fileName = Name;
        using StreamReader reader = new StreamReader(fileName);
        string line;
        Entry newEntry = new Entry(); // creates new entry and allows me to store it.

        while ((line = reader.ReadLine()) !=null)
        {
            string[] parts = line.Split(",");
            newEntry._date = parts[0]; // save date
            newEntry._prompt = parts[1]; // save prompt
            newEntry._response = parts[2]; // save response
            _entries.Add(newEntry); // add to entry class
        }
    }
}