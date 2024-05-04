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
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
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

            else if (input == 2)
            {
                theJournal.DisplayAll();
            }

            else if (input == 3)
            {
                Console.WriteLine("What is the name of your file?");
                theJournal.filename = Console.ReadLine();
                theJournal.LoadFromFile();
                
            }

            else if (input == 4)
            {
                Console.WriteLine("What is the filename? ");
                theJournal.filename = Console.ReadLine();
                theJournal.SaveToFile();
                Console.WriteLine("Entries saved successfully. ");
            }



        }while (input != 5);

    }

}