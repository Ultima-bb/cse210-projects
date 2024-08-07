using System;

class Program
{
    static void Main(string[] args)
    {
        Address _address1 = new Address("123 Main St", "Niagara Falls", "NY", "USA");
        Address _address2 = new Address("456 Elm St", "Niagara Falls", "ON", "Canada");

        Customer _customer1 = new Customer("Burt Simmons", _address1);
        Customer _customer2 = new Customer("Carol Smart", _address2);

        Product _product1 = new Product("Laptop", "MFNG2M3", 120m, 1);
        Product _product2 = new Product("Mouse", "ON8NSU", 25m, 2);
        Product _product3 = new Product("Keyboard", "P0GR2HR", 50m, 1);

        Order _order1 = new Order(_customer1);
        _order1.AddProduct(_product1);
        _order1.AddProduct(_product2);

        Order _order2 = new Order(_customer2);
        _order2.AddProduct(_product2);
        _order2.AddProduct(_product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(_order1.GetPackingLabel());
        Console.WriteLine(_order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${_order1.CalculateTotalPrice()}");

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(_order2.GetPackingLabel());
        Console.WriteLine(_order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${_order2.CalculateTotalPrice()}");
    }
}