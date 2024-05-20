using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void RunBreathingActivity()
    {
    
        GetDisplayStartingMessage();

      
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        
        int timeLeft = _duration;


        while (timeLeft > 0)
        {
            if (timeLeft >= 10)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(5);

                Console.WriteLine("Breathe out...");
                ShowCountDown(5);

                timeLeft -= 10; // Reduce the time left by the 10 seconds for one full breathing cycle
            }
            else
            {
                // If less than 10 seconds remain, adjust the final cycle accordingly
                int halfTime = timeLeft / 2;

                Console.WriteLine("Breathe in...");
                ShowCountDown(halfTime);

                Console.WriteLine("Breathe out...");
                ShowCountDown(timeLeft - halfTime);

                timeLeft = 0; 
            }
        }

        
        Console.WriteLine("Well done!!");
        ShowSpinner(5);

        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");
    }
}
