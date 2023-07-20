
public class Address
{
    
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;

     public Address(string street, string city, string state, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipCode =zipCode;
    }
    public override string ToString()
    {
        return $"\n {_street}\n {_city}\n {_state}\n {_zipCode}\n {_country}";
    }
}