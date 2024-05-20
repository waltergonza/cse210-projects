using System;

class Program
{
    static void Main(string[] args)
    {
        string choice;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by guiding you through deep breathing exercises.");
                    breathingActivity.RunBreathingActivity();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.RunListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != "4");
    }
}
