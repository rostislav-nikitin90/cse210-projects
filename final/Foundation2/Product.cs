namespace Foundation2;

public class Product
{
    private string _productName;
    private string _productId;
    private float _productPrice;
    private int _quantity;

    public Product(string productName, string productId, float productPrice, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _quantity = quantity;      
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public float GetTotalPrice()
    {
        return _productPrice * _quantity;
    }
}