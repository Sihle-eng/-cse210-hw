using System;

public class Customer
{
    private string _name;
    private Address address;

    public Customer()
    {
        _name = "Emily";
        address = new Address("USA", "Washignton", "DC", "Cape");
    }
    public Customer(string name ,Address address)
    {
        _name = name;
        this.address = address;
    }
    public string GetCountry()
    {
        return address.ToString().Split(':')[0].Trim();
    }
    public string Name => _name;
    public Address Address =>address;
    public override string ToString()
    {
        return $"{_name}: {address}";
    }
}