using System;
using System.Collections.Generic;
class Program
{    
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 9999;
        int finish = 0;
        int sum = 0;
        int average = 0;
        int count = 0;
        int larger = 0;

        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Let's make a list of numbers!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
      
        while (number != finish)
        {
            Console.Write("Enter number: ");
            string stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);
        
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        foreach (int i  in numbers)
        {
            sum = sum + i;
            count = count + 1;
            if (i > larger)
            {
                larger = i;
            }
        }
        average = sum / count;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {larger}");

    }
}