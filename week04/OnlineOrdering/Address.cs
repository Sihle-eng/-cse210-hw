using System;

public class Address 
{
    private string _streetId;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _streetId = "Ngwenya";
        _city = "Manzini";
        _state = "Manzini";
        _country = "Eswatini";

    }
    public Address(string country, string state, string city, string streetId)
    {
        _country = country;
        _state = state;
        _city = city;
        _streetId = streetId;
    }
    public override string ToString()
    {
        return $"{_country}: {_state}, {_city}, {_streetId}";
    }
}