using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string stringUserGrade = Console.ReadLine();
        int numberUserGrade = int.Parse(stringUserGrade);

        if (numberUserGrade >= 90)
        {
            letter = "A";
        }
        else if (numberUserGrade >= 80)
        {
            letter = "B";
        }
        else if (numberUserGrade >= 70)
        {
            letter = "C";
        }
        else if (numberUserGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (numberUserGrade >= 70)
        {
            Console.WriteLine("Congratulation you pass the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the class!");
        }

    }
}