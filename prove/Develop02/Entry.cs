using System;

public class Entry
{
    public string _Date;
    public string _PromptText;
    public string _EntryText;



    public void Display ()
    {

        Console.WriteLine($"Date: {_Date} - Prompt: {_PromptText}");
        Console.WriteLine($"Entry: {_EntryText}");
    
    }
}