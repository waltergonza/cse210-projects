using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment1 = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Watters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}