public class StationaryBicycle : Activity
{
    protected double _speed; 

    public StationaryBicycle(DateTime date, int _lengthInMinutes, double _speed)
        : base(date, _lengthInMinutes)
    {
        this._speed = _speed;
    }

    public override double GetSpeed()
    {
        return _speed; 
    }

    public override double GetPace()
    {
        return 60.0 / _speed; 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
}
