using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "Anystate", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "Otherstate", "USA");
        Address address3 = new Address("789 Oak St", "Elsewhere", "Elsestate", "USA");

        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in tech", "2024-06-01", "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Wedding Reception", "Celebrate the union of John and Jane", "2024-06-02", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Community Picnic", "Join us for a fun day in the park", "2024-06-03", "11:00 AM", address3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, gathering };

        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("-----------");
        }
    }
}