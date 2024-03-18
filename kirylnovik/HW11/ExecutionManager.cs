namespace HW11;

public class ExecutionManager<T> where T : Product
{
    private readonly IEnumerable<T> _products;
    private readonly Func<IEnumerable<T>, decimal> _calculateTotalValue;
    private readonly Func<IEnumerable<T>, decimal> _calculateAveragePrice;
    private readonly Func<IEnumerable<T>, T> _getMaxPrice;
    private readonly Func<IEnumerable<T>, T> _getMinPrice;
    
    public ExecutionManager(IEnumerable<T> products, 
        Func<IEnumerable<T>, decimal> calculateTotalValue, 
        Func<IEnumerable<T>, decimal> calculateAveragePrice,
        Func<IEnumerable<T>, T> getMaxPrice,
        Func<IEnumerable<T>, T> getMinPrice)
    {
        _products = products;
        _calculateTotalValue = calculateTotalValue;
        _calculateAveragePrice = calculateAveragePrice;
        _getMaxPrice = getMaxPrice;
        _getMinPrice = getMinPrice;
    }
    
    public decimal CalculateTotalValue()
    {
        return _calculateTotalValue(_products);
    }

    public decimal CalculateAveragePrice()
    {
        return _calculateAveragePrice(_products);
    }

    public T GetMaxPrice()
    {
        return _getMaxPrice(_products);
    }

    public T GetMinPrice()
    {
        return _getMinPrice(_products);
    }
}