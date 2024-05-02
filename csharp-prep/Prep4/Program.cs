using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>(); 

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        int Input;
        int total = 0;

        do
        {
            Console.Write("Enter number: ");
            Input = int.Parse(Console.ReadLine());
            numbers.Add(Input);

        }while (Input != 0);

        //adding the numbers of the list.
        foreach(int i in numbers)
        {
            total += i;
    
        }

        //average. 
        float Average = (float)total / numbers.Count;

        //largest number
        int max = numbers.Max();


        Console.WriteLine("The sum is " + total);
        Console.WriteLine("The average is " + Average);
        Console.WriteLine("The maximun number is: " + max);
    
    }
}

