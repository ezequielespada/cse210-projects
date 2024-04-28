using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int userNumber = 9999;
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("I have a magic number");
        Console.WriteLine("Try to guess my magic number");
      
        while (userNumber != magicNumber)
        {
            Console.Write("What is you guess? ");
            string userStringNumber = Console.ReadLine();
            userNumber = int.Parse(userStringNumber);
        
            if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
        }
        if (userNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
    }
}