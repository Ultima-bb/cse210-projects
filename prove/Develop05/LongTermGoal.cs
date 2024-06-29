class LongTermGoal : Goal
{
    public LongTermGoal(string _name, int _points)
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