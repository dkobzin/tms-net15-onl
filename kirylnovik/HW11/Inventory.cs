namespace HW11;

public class Inventory<T> where T : Product
{
    private readonly List<T> _products = [];

    public void AddProduct(T product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(int id)
    {
        _products.RemoveAll(p => p.Id == id);
    }

    public decimal CalculateInventoryValue()
    {
        return _products.Sum(product => product.Price * product.Count);
    }

    public void DisplayAllProducts()
    {
        foreach (var product in _products)
        {
            Console.WriteLine($"ID: {product.Id}, Название: {product.Name}, Цена за 1 продукт: {product.Price} BYN, Количество: {product.Count}");
        }
    }
    
    public ExecutionManager<T> CreateExecutionManager()
    {
        return new ExecutionManager<T>(_products, CalculateTotalValue, CalculateAveragePrice, GetMaxPrice, GetMinPrice);
    }
    
    private static decimal CalculateTotalValue(IEnumerable<T> products)
    {
        return products.Sum(product => product.Price * product.Count);
    }

    private static decimal CalculateAveragePrice(IEnumerable<T> products)
    {
        return products.Any() ? products.Average(product => product.Price) : 0;
    }

    private static T GetMaxPrice(IEnumerable<T> products)
    {
        if (!products.Any())
            throw new InvalidOperationException("Список продуктов пуст.");

        return products.Max();
    }

    private static T GetMinPrice(IEnumerable<T> products)
    {
        if (!products.Any())
            throw new InvalidOperationException("Список продуктов пуст.");

        return products.Min();
    }
}