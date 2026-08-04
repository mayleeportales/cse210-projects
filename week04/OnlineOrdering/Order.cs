public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    private decimal GetShippingCost()
    {
        decimal shipping = 0m;

        if (_customer.IsCustomerInUsa())
        {
            shipping = 5m;
        }
        else
        {
            shipping = 35m;
        }

        return shipping;
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        return total + GetShippingCost();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetName()} / ID: {product.GetId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()}\nAddress: {_customer.GetAddress().GetFullAddress()}";
    }
}