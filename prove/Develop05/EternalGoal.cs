public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        // Sumar puntos cada vez
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() =>
        $"{GetName()} - {GetPoints()} points (Eternal)";

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }

    public static EternalGoal CreateFromString(string details)
    {
        string[] parts = details.Split(',');
        return new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
    }
}
