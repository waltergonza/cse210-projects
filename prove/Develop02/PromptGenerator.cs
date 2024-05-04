using System;

public class PromptGenerator
{

    public List<string>_prompts = new List<string>(5)
    {
        
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"

    };



    public string GetRandomPrompt()
    {
        Random r = new Random();
        int index = r.Next(_prompts.Count);
        string RandomString = _prompts[index];

        Console.WriteLine(RandomString);

        return _prompts[index];
                
    }
}