
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool GetIsFromUSA()
    {
        if(_country.ToUpper().Equals("USA"))
        {
            return true;
        }
        
        return false;

        
    }
    public string GetFormattedAddress()
    {
        string neatAddress = $"{_street}\n {_city}\n {_state}\n {_country}";
        return neatAddress;
    }
    

}