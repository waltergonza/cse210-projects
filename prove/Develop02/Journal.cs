using System;
using System.Reflection.Metadata.Ecma335;

public class Journal
{

    public List <Entry> _entries = new List<Entry>();


    
    // 1 write
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }



    //2 Display
    public void DisplayAll ()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }



    //3 load
    public void LoadFromFile()
    {

       string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {

            Console.WriteLine(line);

        }
            
            
    }



    //4 save
    public string filename;
    public void SaveToFile()
    {
        
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._Date} - {entry._PromptText}");
                outputFile.WriteLine($"Answer: {entry._EntryText}");
            }
        }
    }



    // 5 delete
    public void DeleteFile()
    {
        File.Delete(filename);
    }

}