using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();  

    public Order(Customer customer)
    {
        _customer = customer;

    } 

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach(var product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }

        if (_customer.isInUsa())
        {
            totalCost += 5;
        }

        else 
        {
            totalCost += 35;
        }
        
        return totalCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"Name: {product.GetProductName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\nName: {_customer.Name}\nAddress: {_customer.Address.GetFullAddress()}";
    }

}