public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public int GetBonus() => _bonus;

    public override string GetDetailsString() =>
        $"{GetName()}: Completed {_amountCompleted}/{_target} times - {GetPoints()} points";

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }

    public static ChecklistGoal CreateFromString(string details)
    {
        string[] parts = details.Split(',');
        return new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]))
        {
            _amountCompleted = int.Parse(parts[5])
        };
    }
}
