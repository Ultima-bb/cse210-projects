public class Swimming : Activity
{
    protected int _laps;

    public Swimming(DateTime _date, int _lengthInMinutes, int _laps)
        : base(_date, _lengthInMinutes)
    {
        this._laps = _laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / (base._lengthInMinutes / 60.0)); 
    }

    public override double GetPace()
    {
        return base._lengthInMinutes / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
