public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected TimeSpan _time;
    protected Address _address;

    // Constructor
    public Event(string _title, string _description, DateTime _date, TimeSpan _time, Address _address)
    {
        this._title = _title;
        this._description = _description;
        this._date = _date;
        this._time = _time;
        this._address = _address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails(); 
    }
    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
