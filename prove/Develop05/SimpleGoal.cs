public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName} - {_description}";
    }

    public void SetCompletion(bool isComplete)
    {
        _isComplete = isComplete;
    }
}
