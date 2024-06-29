class DailyGoal : Goal
{
    public DailyGoal(string _name, int _points)
    {
        Name = _name;
        Points = _points;
        IsCompleted = false;
    }

    public override string DisplayGoal()
    {
        return $"[ ] {Name} ({Points} points)";
    }
}