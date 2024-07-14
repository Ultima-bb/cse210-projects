public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string _title, string _description, DateTime _date, TimeSpan _time, Address _address, string _weatherForecast)
        : base(_title, _description, _date, _time, _address)
    {
        this._weatherForecast = _weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}