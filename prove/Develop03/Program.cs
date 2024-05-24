using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var scriptures = LoadScripturesFromFile("scriptures.txt");
        if (scriptures == null || scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in the file.");
            return;
        }

        Scripture scripture = null;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Select a scripture");
            Console.WriteLine("2. Practice a random scripture");
            Console.WriteLine("3. Exit");

            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                for (int i = 0; i < scriptures.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {scriptures[i].Item1.GetDisplayText()}");
                }
                Console.Write("Enter the number of the scripture you want to practice: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= scriptures.Count)
                {
                    scripture = new Scripture(scriptures[choice - 1].Item1, scriptures[choice - 1].Item2);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                }
            }
            else if (input == "2")
            {
                var random = new Random();
                var randomIndex = random.Next(scriptures.Count);
                scripture = new Scripture(scriptures[randomIndex].Item1, scriptures[randomIndex].Item2);
                break;
            }
            else if (input == "3")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid option. Press Enter to continue.");
                Console.ReadLine();
            }
        }

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

        Console.WriteLine("All words are hidden. Program has ended.");
    }

    static List<Tuple<Reference, string>> LoadScripturesFromFile(string filePath)
    {
        var scriptures = new List<Tuple<Reference, string>>();

        try
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    var referenceText = parts[0];
                    var text = parts[1];

                    var referenceParts = referenceText.Split(' ');
                    var book = referenceParts[0];
                    var chapterAndVerses = referenceParts[1].Split(':');
                    var chapter = int.Parse(chapterAndVerses[0]);
                    var verses = chapterAndVerses[1].Split('-');

                    Reference reference;
                    if (verses.Length == 1)
                    {
                        var verse = int.Parse(verses[0]);
                        reference = new Reference(book, chapter, verse);
                    }
                    else
                    {
                        var startVerse = int.Parse(verses[0]);
                        var endVerse = int.Parse(verses[1]);
                        reference = new Reference(book, chapter, startVerse, endVerse);
                    }

                    scriptures.Add(Tuple.Create(reference, text));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }

        return scriptures;
    }
}