namespace Foundation2;
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

    public bool IsAddressUSA()
    {
        if( _country.ToUpper().Equals("USA"))
        {
            return true;
        }
        return false;
    }

    public string GetAddressInfo()
    {
        string addressInfo = $"{_street}, {_city}, {_state}, {_country}";
        return addressInfo;
    }

}