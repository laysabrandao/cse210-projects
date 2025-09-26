using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    //constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    //add a product
    public void AddProduct(string name, int id, double price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }

    //total cost + shipping
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        //+ shipping cost
        total += _customer.IsUSA() ? 5 : 35;

        return total;
    }

    //packing label (products)
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    //shipping label (customer + address)
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
