public class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual float GetDistance()
    {
        return 0f;
    }

    public virtual float GetSpeed()
    {
        return 0f;
    }

    public virtual float GetPace()
    {
        return 0f;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Activity ({_lengthInMinutes} min)";
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }
}
