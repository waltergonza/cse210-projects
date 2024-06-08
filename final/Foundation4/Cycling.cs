public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateTime date, int lengthInMinutes, float speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return (_speed * GetLengthInMinutes()) / 60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Cycling ({GetLengthInMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
