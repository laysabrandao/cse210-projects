public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    //constructor
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    //check if usa
    public bool IsUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }

    //return full address(string)
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}
