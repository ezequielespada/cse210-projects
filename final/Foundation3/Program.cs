using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear eventos
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Event lecture = new Lecture("Tech Talk", "Advanced C# Techniques", "10/10/2023", "10:00 AM", address1, "John Doe", 100);

        Address address2 = new Address("456 Elm St", "Vancouver", "BC", "Canada");
        Event reception = new Reception("Company Meetup", "Annual company gathering", "11/11/2023", "6:00 PM", address2, "rsvp@company.com");

        Address address3 = new Address("789 Oak St", "Miami", "FL", "USA");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "Picnic for the neighborhood", "12/12/2023", "12:00 PM", address3, "Sunny");

        // Crear lista de eventos
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Mostrar mensajes de marketing
        foreach (Event eventItem in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine("Short Description:");
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine();
        }
    }
}