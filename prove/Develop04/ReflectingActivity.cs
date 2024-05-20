using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
       
        GetDisplayStartingMessage();

     
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

       
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

     
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

       
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

     
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

       
        Random random = new Random();
        int timeLeft = _duration;
        while (timeLeft >= 5 && _questions.Count > 0)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5);
            timeLeft -= 5;
        }

       
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index); // Remove the question to avoid repetition
        return question;
    }
}
