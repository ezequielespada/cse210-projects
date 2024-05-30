class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Gratitude");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadLine();
                continue;
            }

            switch (choice)
            {
                case 1:
                    RunActivity(new BreathingActivity());
                    break;
                case 2:
                    RunActivity(new ListingActivity());
                    break;
                case 3:
                    RunActivity(new ReflectingActivity());
                    break;
                case 4:
                    RunActivity(new GratitudeActivity());
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RunActivity(Activity activity)
    {
        activity.Run();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}