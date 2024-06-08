using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "Anystate", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "Otherstate", "USA");
        Address address3 = new Address("789 Oak St", "Sometown", "Somestate", "USA");

        Event lecture = new Lecture("Tech Talk", "An insightful tech talk.", new DateTime(2024, 6, 15), "10:00 AM", address1, "John Doe", 100);
        Event reception = new Reception("Networking Event", "An evening of networking.", new DateTime(2024, 6, 20), "6:00 PM", address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic", "A fun outdoor picnic.", new DateTime(2024, 6, 25), "12:00 PM", address3, "Sunny");

        PrintEventDetails(lecture);
        PrintEventDetails(reception);
        PrintEventDetails(outdoorGathering);
    }

    public static void PrintEventDetails(Event e)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(e.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(e.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(e.GetShortDescription());
        Console.WriteLine("===================================");
    
    }
}