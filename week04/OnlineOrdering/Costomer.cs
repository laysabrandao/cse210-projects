public class Customer
{
    private string _name;
    private Address _address;

    //constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName() => _name;
    public Address GetAddress() => _address;

    //check if the customer is in the usa
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}
