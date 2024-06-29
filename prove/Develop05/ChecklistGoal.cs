class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _requiredTimes;

    public ChecklistGoal(string _name, int _points, int _requiredTimes)
    {
        Name = _name;
        Points = _points;
        this._requiredTimes = _requiredTimes;
        _timesCompleted = 0;
        IsCompleted = false;
    }

    public override void CompleteGoal()
    {
        base.CompleteGoal();
        _timesCompleted++;
        if (_timesCompleted == _requiredTimes)
        {
            Points += 50; 
        }
    }

    public override string DisplayGoal()
    {
        return $"[ ] {Name} (Completed {_timesCompleted}/{_requiredTimes} times, {Points} points)";
    }
}