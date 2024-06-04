class Event
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Date { get; private set; }
    public string Time { get; private set; }
    public Address Address { get; private set; }

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{Title}\n{Description}\n{Date} at {Time}\nLocation: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {Title}\nDate: {Date}";
    }
}