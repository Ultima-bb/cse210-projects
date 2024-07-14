public class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Customer(string _name, Address _address)
    {
        Name = _name;
        Address = _address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}
