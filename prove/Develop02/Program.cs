using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit ");
        
        
        int input; 

        
        do
        {
            Console.WriteLine("What would you like to do? ");
            input = int.Parse(Console.ReadLine());

            //write
            if (input == 1)
            {

                
                // Console.WriteLine("What would you like to do? ");

            }



        }while (input != 5);




        Entry anEntry = new Entry();



        PromptGenerator answer = new PromptGenerator();
        answer._AllPrompts = "Who was the most interesting person I interacted with today? ";



    }


}