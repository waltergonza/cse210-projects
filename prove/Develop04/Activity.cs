using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void GetDisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin... ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        int index = 0;
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(animationStrings[index]);
            Thread.Sleep(250);
            Console.Write("\b");
            index = (index + 1) % animationStrings.Count;
        }
    }
}
