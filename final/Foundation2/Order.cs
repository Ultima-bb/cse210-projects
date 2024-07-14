public class Order
{
    private List<Product> _products = new List<Product>();
    public Customer Customer { get; set; }

    public Order(Customer _customer)
    {
        Customer = _customer;
    }

    public void AddProduct(Product _product)
    {
        _products.Add(_product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal _totalProductCost = 0;
        foreach (var _product in _products)
        {
            _totalProductCost += _product.CalculateTotalCost();
        }

        decimal _shippingCost = Customer.IsInUSA() ? 5 : 35;
        return _totalProductCost + _shippingCost;
    }

    public string GetPackingLabel()
    {
        string _packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            _packingLabel += $"- {product.Name} (ID: {product.ProductId})\n";
        }
        return _packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n {Name}: {Customer.Address.GetFullAddress()}";
    }
}