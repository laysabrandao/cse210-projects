public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    //constructor
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //getters
    public string GetName() => _name;
    public int GetProductId() => _productId;

    //total cost for product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
