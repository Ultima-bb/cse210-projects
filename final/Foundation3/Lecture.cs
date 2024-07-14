public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;

    public Lecture(string _title, string _description, DateTime _date, TimeSpan _time, Address _address, string _speaker, int _capacity)
        : base(_title, _description, _date, _time, _address)
    {
        this._speaker = _speaker;
        this._capacity = _capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
