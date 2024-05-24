using System;

class Program
{
    static void Main()
    {
        var reference = new Reference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Program has ended.");
    }
}
