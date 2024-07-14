using System;

class Program
{
    static void Main(string[] args)
    {
        Address _address1 = new Address("123 Main St", "Lewiston", "ID", "USA");
        Address _address2 = new Address("456 Elm St", "Niagara Falls", "ON", "Canada");
        Address _address3 = new Address("789 Oak Ave", "Niagara Falls", "NY", "USA");

        Event _event1 = new Lecture("How to Punch through solid steel.", "Learn how to punch through pretty much anything. Demonstrations available.", new DateTime(2024, 7, 15), new TimeSpan(10, 0, 0), _address1, "John Wick", 50);
        Event _event2 = new Reception("10 year reunion of Arkham assylum", "They actually let us out, can you believe?", new DateTime(2024, 8, 1), new TimeSpan(18, 0, 0), _address2, "PureMaddness@singtome.org");
        Event _event3 = new OutdoorGathering("RocknRoll Fest", "From the 80's, to the early 2000's. It's gonna be a long night.", new DateTime(2024, 7, 30), new TimeSpan(12, 0, 0), _address3, "Tornados, hurricanes, and earthquakes from electric guitars.");

        Console.WriteLine("Event 1:");
        Console.WriteLine(_event1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(_event1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(_event1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Event 2:");
        Console.WriteLine(_event2.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(_event2.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(_event2.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Event 3:");
        Console.WriteLine(_event3.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(_event3.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(_event3.GetShortDescription());
    }
}