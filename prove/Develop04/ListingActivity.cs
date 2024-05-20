using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    public void RunListingActivity()
    {
        GetDisplayStartingMessage();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        Console.WriteLine("You may begin listing your responses now:");
        List<string> responses = GetListFromUser();

        Console.WriteLine($"You listed {responses.Count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
            timeLeft -= 5;
        }
        return responses;
    }
}
