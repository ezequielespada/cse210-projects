using System;
using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine("----");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string date;
            while ((date = reader.ReadLine()) != null)
            {
                string promptText = reader.ReadLine();
                string entryText = reader.ReadLine();
                reader.ReadLine();
                Entry entry = new Entry
                {
                    _date = date,
                    _promptText = promptText,
                    _entryText = entryText
                };
                _entries.Add(entry);
            }
        }
    }
}