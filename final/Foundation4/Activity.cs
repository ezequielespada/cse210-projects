abstract class Activity
{
    public string Date { get; private set; }
    public int Minutes { get; private set; }

    public Activity(string date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}