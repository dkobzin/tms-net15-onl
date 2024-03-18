namespace HW11;

public class Product(int id, string name, decimal price, int count) : IComparable<Product>
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public decimal Price { get; } = price;
    public int Count { get; } = count;
    
    public int CompareTo(Product product)
    {
        return product == null ? 1 : Price.CompareTo(product.Price);
    }
}