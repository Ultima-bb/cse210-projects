public class Activity
{
    protected DateTime _date;
    protected int _lengthInMinutes;

    public Activity(DateTime date, int _lengthInMinutes)
    {
        this._date = date;
        this._lengthInMinutes = _lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} ({_lengthInMinutes} min)";
    }
}