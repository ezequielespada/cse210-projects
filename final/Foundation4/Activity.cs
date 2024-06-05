public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes; // Length in minutes

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public int LengthInMinutes
    {
        get { return _lengthInMinutes; }
    }

    public abstract double GetDistance(); // Distance in km
    public abstract double GetSpeed(); // Speed in km/h
    public abstract double GetPace(); // Pace in min/km

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_lengthInMinutes} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km";
    }
}