using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Eternal Quest");
                Console.WriteLine("1. Display Player Info");
                Console.WriteLine("2. List Goal Names");
                Console.WriteLine("3. List Goal Details");
                Console.WriteLine("4. Create Goal");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Save Goals");
                Console.WriteLine("7. Load Goals");
                Console.WriteLine("8. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        goalManager.DisplayPlayerInfo();
                        break;
                    case "2":
                        goalManager.ListGoalNames();
                        break;
                    case "3":
                        goalManager.ListGoalDetails();
                        break;
                    case "4":
                        CreateGoal(goalManager);
                        break;
                    case "5":
                        RecordEvent(goalManager);
                        break;
                    case "6":
                        Console.Write("Enter filename to save goals: ");
                        string saveFilename = Console.ReadLine();
                        goalManager.SaveGoals(saveFilename);
                        break;
                    case "7":
                        Console.Write("Enter filename to load goals: ");
                        string loadFilename = Console.ReadLine();
                        goalManager.LoadGoals(loadFilename);
                        break;
                    case "8":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CreateGoal(GoalManager goalManager)
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Negative Goal");
            Console.Write("Select an option: ");
            string goalType = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();

            Console.Write("Enter goal points: ");
            int points = int.Parse(Console.ReadLine());

            Goal goal = null;

            switch (goalType)
            {
                case "1":
                    goal = new SimpleGoal(name, description, points);
                    break;
                case "2":
                    goal = new EternalGoal(name, description, points);
                    break;
                case "3":
                    Console.Write("Enter target number of completions: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goal = new ChecklistGoal(name, description, points, target, bonus);
                    break;
                case "4":
                    goal = new NegativeGoal(name, description, points);
                    break;
                default:
                    Console.WriteLine("Invalid goal type, please try again.");
                    return;
            }

            goalManager.CreateGoal(goal);
        }

        static void RecordEvent(GoalManager goalManager)
        {
            Console.WriteLine("Select a goal to record an event:");
            goalManager.ListGoalNames();
            Console.Write("Enter the goal name: ");
            string goalName = Console.ReadLine();

            Goal goal = goalManager.FindGoal(goalName);
            if (goal != null)
            {
                goalManager.RecordEvent(goal);
            }
            else
            {
                Console.WriteLine("Goal not found, please try again.");
            }
        }
    }
}
