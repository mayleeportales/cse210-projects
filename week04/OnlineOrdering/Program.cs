using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");
        Address address2 = new Address("Rua Dos Bandeirantes 110", "Salvador", "BA", "Brazil");
        
        Customer customer1 = new Customer("John Carpenter", address1);
        Customer customer2 = new Customer("Maria Angelica", address2);

        Order order1 = new Order(customer1);        
        Order order2 = new Order(customer2);

        Product product1Order1 = new Product("Portable Power Bank", 3650426, 30m, 1);
        order1.AddProduct(product1Order1);
        Product product2Order1 = new Product("Adjustable Desk Lamp", 4005208, 15m, 2);
        order1.AddProduct(product2Order1);
        Product product3Order1 = new Product("Meditation Cushion", 1242783, 20m, 4);
        order1.AddProduct(product3Order1);

        Product product1Order2 = new Product("Stainless Steel Water Bottle", 4657890, 30m, 2);
        order2.AddProduct(product1Order2);
        Product product2Order2 = new Product("Aromatherapy Diffuser", 2004005, 25m, 2);
        order2.AddProduct(product2Order2);
        Product product3Order2 = new Product("Fitness Tracker Watch", 3004006, 20m, 4);
        order2.AddProduct(product3Order2);

        Console.WriteLine($"***Order 1***\n==Packing Label==\n{order1.GetPackingLabel()}\n==Shipping Label==\n{order1.GetShippingLabel()}\nTotal Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();
        Console.WriteLine($"***Order 2***\n==Packing Label==\n{order2.GetPackingLabel()}\n==Shipping Label==\n{order2.GetShippingLabel()}\nTotal Cost: ${order2.GetTotalCost()}");
    }
}