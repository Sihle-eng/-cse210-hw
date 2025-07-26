using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product()
    {
        _name = "Perfume";
        _productId = "423";
        _price = 8;
        _quantity = 2;
    }
    public Product(string name, string product)
    {
        _name = name;
        _productId = product;
        // return $"{_name}: {_productId}";
    }
    public Product(double price, int quantity)
    {
        _price = price;
        _quantity = quantity;
        // return $"{_price}| {_quantity}";
    }
    public double GetTotal()
    {
        return  _price * _quantity;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"{_name} {_productId} {_price} {_quantity}");
    }
}