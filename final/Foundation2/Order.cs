namespace Foundation2;
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private float _total;
    private float _shippingCost;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;

        if (customer.IsCustomerInUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        _products = products;
        CalculateTotal();
    }

    public void CalculateTotal()
    {
        _total = _shippingCost;
        foreach (Product product in _products)
        {
            _total += product.GetTotalPrice();
        }
    }

    public float GetTotal()
    {
        return _total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetProductName()}\nProduct ID: {product.GetProductId()}\n\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label:\nCustomer: {_customer.GetCustomerName()}, Customer Address: {_customer.GetCustomerAddress().GetAddressInfo()}\n";
        return shippingLabel;
    }
}