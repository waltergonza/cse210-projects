using System;

public class Journal
{
    public List <Entry> _entries = new List<Entry>();
    
    
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll ()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public string filename;
    public void SaveToFile()
    {
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._Date} - {entry._PromptText}");
                outputFile.WriteLine($"Answer: {entry._EntryText}");
            }
        }
    }

    public void LoadFromFile()
    {
       string[] lines = File.ReadAllLines(filename);
        _entries.Clear();  // Clear existing entries to avoid duplicates
        foreach (string line in lines)
        {
            string[] parts = line.Split('-');

            if (parts.Length >= 3) // Make sure that each line has at least three parts
            {
                Entry load = new Entry
                {
                    _Date = parts[0].Trim(),
                    _PromptText = parts[1].Trim(),
                    _EntryText = parts[2].Trim()
                };
                _entries.Add(load);
            }
        }
                
            
    }

}