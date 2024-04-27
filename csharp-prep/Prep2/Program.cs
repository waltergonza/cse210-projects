using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string Letter = "";
        

        if (grade >= 90)
        {
            Letter = "A";

        }
        else if (grade >= 80)
        {
            Letter = "B";

        }
        else if (grade >= 70)
        {
            Letter = "C";

        }
        else if (grade >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You've passed successfully, your letter grade is {Letter}");
        }
        else
        {
            Console.WriteLine($"It seems you couldn't pass, your letter grade is {Letter} ");
        }

    }
}