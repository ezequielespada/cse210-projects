using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear actividades
        Activity running = new Running("03 Nov 2023", 30, 3.0);
        Activity cycling = new Cycling("03 Nov 2023", 30, 15.0);
        Activity swimming = new Swimming("03 Nov 2023", 30, 20);

        // Crear lista de actividades
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Mostrar resúmenes de actividades
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}