class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date} Swimming ({Minutes} min): Laps {GetDistance() / 0.62 * 1000 / 50}, Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}