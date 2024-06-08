public class Running : Activity
{
    private float _distance;

    public Running(DateTime date, int lengthInMinutes, float distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return (_distance / GetLengthInMinutes()) * 60;
    }

    public override float GetPace()
    {
        return GetLengthInMinutes() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetLengthInMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}