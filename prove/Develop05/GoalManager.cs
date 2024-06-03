using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        _score += goal.GetPoints();

        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
        {
            _score += checklistGoal.GetBonus();
        }
    }

    public Goal FindGoal(string name)
    {
        return _goals.Find(g => g.GetName() == name);
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Save the score
            outputFile.WriteLine(_score);

            // Save each goal
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string details = parts[1];

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(SimpleGoal.CreateFromString(details));
                    break;
                case "EternalGoal":
                    _goals.Add(EternalGoal.CreateFromString(details));
                    break;
                case "ChecklistGoal":
                    _goals.Add(ChecklistGoal.CreateFromString(details));
                    break;
                case "NegativeGoal":
                    _goals.Add(NegativeGoal.CreateFromString(details));
                    break;
            }
        }
    }
}
