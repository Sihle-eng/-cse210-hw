using System;

public class Order
{
    private string _shippingLabel;
    private string _packagingLabel;
    private List<Product> _product;
    private List<Customer> _customer;

    public Order()
    {
        _shippingLabel = "";
        _packagingLabel = "";
        _product = new List<Product>();
        _customer = new List<Customer>();
    }
    public Order(string packaging, string shipping, List<Product> products, List<Customer> customers)
    {
        _shippingLabel = shipping;
        _packagingLabel = packaging;
        _product = products ?? new List<Product>();
        _customer = customers ?? new List<Customer>();
        // return $"{_shippingLabel}: {_packagingLabel}";
    }
    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in _product)
        {
            total += product.GetTotal();
        }
        string country = _customer.Count > 0 ? _customer[0].GetCountry() : "Unknwon";
        total += country == "USA" ? 5 : 35;

        return total;
    }
    public string GetShippingLabel()
    {
        return $"{_customer[0].Name}: {_customer[0].Address}";
    }

    public string GetPackagingLabel()
    {
        string label = "";
        foreach (Product product in _product)
        {
            label += product.ToString() + "\n"; 
        }
        return label;
    }
}