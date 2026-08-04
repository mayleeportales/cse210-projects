using System.Data.Common;

public class Product
{
    private string _name;
    private int _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, int id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}