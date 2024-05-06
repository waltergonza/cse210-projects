using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
       
        int input; 
        string answer;

        //RANDOM GENERATOR PROMPTS
        PromptGenerator _prompt = new PromptGenerator();

        //ENTRIES
        Entry anEntry = new Entry();
        
        
        //JOURNAL
        Journal theJournal = new Journal();
        
        do
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Delete file\n6. Quit\nWhat would you like to do? ");
            input = int.Parse(Console.ReadLine());

       

            //write
            if (input == 1)
            {
       
                answer = _prompt.GetRandomPrompt();
                string response = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._PromptText = answer;
                newEntry._EntryText = response;
                newEntry._Date = DateTime.Now.ToString();

                theJournal.AddEntry(newEntry);
        
            }

            //Display
            else if (input == 2)
            {
                theJournal.DisplayAll();
            }

            //Load
            else if (input == 3)
            {
                Console.WriteLine("What is the name of your file?");
                theJournal.filename = Console.ReadLine();
                theJournal.LoadFromFile();
                if (input == 1)
                {
                   theJournal.SaveToFile();
                }
                
            }

            //Save
            else if (input == 4)
            {
                
                Console.WriteLine("What is the filename? ");
                theJournal.filename = Console.ReadLine();
                theJournal.SaveToFile();
                Console.WriteLine("Entries saved successfully. ");
            }

            //Delete a file
            else if (input == 5)
            {
                Console.WriteLine("Enter the name of the file: ");
                theJournal.filename = Console.ReadLine();
                theJournal.DeleteFile();
                Console.WriteLine($"Your file ''{theJournal.filename}'' was deleted successfully.");
            }


            //Quit
        }while (input != 6);

    }

}