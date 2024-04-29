using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        //variables for function:

        DisplayMessage ();

        string userName = DisplayUserName();

        int favoriteNumber = DisplayUserNumber();

        int square = SquareNumber(favoriteNumber);

        DisplayResult(userName, square);



        //DisplayWelcome

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //PromptUserName

        static string DisplayUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
            
        }

        //PromptUserNumber

        static int DisplayUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        
        }

        //SquareNumber

        static int SquareNumber(int number)

        {
            return number * number;
        }

        //Display final result

        static void DisplayResult(string userName, int square)
        {
            Console.Write($"{userName}, The square of your number is: {square}");
        }


    }
}