public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return (_laps * 50f) / 1000f * 0.62f;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / GetLengthInMinutes()) * 60;
    }

    public override float GetPace()
    {
        return GetLengthInMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetLengthInMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}