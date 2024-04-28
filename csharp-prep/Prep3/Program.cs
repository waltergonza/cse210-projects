using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //asking for a magic number.
        
        // Console.Write("What is the magic number? ");
        // string first = Console.ReadLine();
        // int number = int.Parse(first);

        //Random numbers:
        Random randomgenerator = new Random();
        int number = randomgenerator.Next(-1, 101);

        int guess = -1;


        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
 

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess< number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }while (guess != number);
     
    }
}