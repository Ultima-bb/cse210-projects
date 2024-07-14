public class Running : Activity
{
    protected double _distance; 

    public Running(DateTime _date, int _lengthInMinutes, double _distance)
        : base(_date, _lengthInMinutes)
    {
        this._distance = _distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (base._lengthInMinutes / 60.0); 
    }

    public override double GetPace()
    {
        return base._lengthInMinutes / _distance; 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
