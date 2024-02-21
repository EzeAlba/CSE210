using System;
using System.Text;

public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productid, decimal price, int quantity)
    {
        _name = name;
        _productId = productid;
        _price = price;
        _quantity = quantity;
    }

    public decimal CalculateTotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _productId;
    }


}