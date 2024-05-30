class GratitudeActivity : Activity
{
    public GratitudeActivity() : base("Gratitude", "This activity will help you reflect on the things you are grateful for in your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Enter things you are grateful for (press Enter after each item, continue until time runs out):");
        List<string> gratefulThings = GetListFromUser();
        Console.WriteLine($"You are grateful for {gratefulThings.Count} things:");
        foreach (var thing in gratefulThings)
        {
            Console.WriteLine($"- {thing}");
        }
        DisplayEndingMessage();
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration); // Usando la propiedad Duration

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a thing you are grateful for: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        return items;
    }
}