using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Park Ave", "Sometown", "NY", "USA");
        Address address3 = new Address("789 Beach Blvd", "Seaside", "FL", "USA");

        Lecture lecture = new Lecture("Tech Talk", "Introduction to C#", DateTime.Parse("2024-01-15"), TimeSpan.Parse("14:00"), address1, "John Doe", 50);
        Reception reception = new Reception("Networking Event", "Meet and Greet", DateTime.Parse("2024-02-20"), TimeSpan.Parse("18:00"), address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Beach Party", "Fun in the Sun", DateTime.Parse("2024-03-25"), TimeSpan.Parse("12:00"), address3, "Sunny with a chance of clouds");

        Event[] events = { lecture, reception, gathering };

        foreach (var e in events)
        {
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
        }
    }
    
}