namespace Foundation2;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public bool IsCustomerInUSA()
    {
        return _address.IsAddressUSA();
    }
    
    public Address GetCustomerAddress()
    {
        return _address;
    }
}