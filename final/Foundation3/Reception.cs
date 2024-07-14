public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string _title, string _description, DateTime _date, TimeSpan _time, Address _address, string _rsvpEmail)
        : base(_title, _description, _date, _time, _address)
    {
        this._rsvpEmail = _rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}