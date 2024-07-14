public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public Address(string _street, string _city, string _stateProvince, string _country)
    {
        Street = _street;
        City = _city;
        StateProvince = _stateProvince;
        Country = _country;
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}