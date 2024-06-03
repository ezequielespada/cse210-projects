public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        // Subtract points every time
        _points = -Math.Abs(_points);
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() =>
        $"{GetName()} - {GetPoints()} points (Negative)";

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_name},{_description},{_points}";
    }

    public static NegativeGoal CreateFromString(string details)
    {
        string[] parts = details.Split(',');
        return new NegativeGoal(parts[0], parts[1], int.Parse(parts[2]));
    }
}
