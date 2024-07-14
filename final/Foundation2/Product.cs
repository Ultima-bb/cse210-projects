public class Product
{
    public string Name { get; set; }
    public string ProductId { get; set; }
    public decimal PricePerUnit { get; set; }
    public int Quantity { get; set; }

    public Product(string _name, string _productId, decimal _pricePerUnit, int _quantity)
    {
        Name = _name;
        ProductId = _productId;
        PricePerUnit = _pricePerUnit;
        Quantity = _quantity;
    }

    public decimal CalculateTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}