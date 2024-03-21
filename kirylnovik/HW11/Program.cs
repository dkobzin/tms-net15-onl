namespace HW11;

internal static class Program
{
    private static void Main()
    {
        var inventory = new Inventory<Product>();
        
        inventory.AddProduct(new Product(1, "Яблоки", 12.5m, 150));
        inventory.AddProduct(new Product(2, "Бананы", 9.3m, 100));
        inventory.AddProduct(new Product(3, "Огурцы", 6.4m, 50));
        inventory.AddProduct(new Product(4, "Арбузы", 17.9m, 300));
        inventory.AddProduct(new Product(5, "Дыни", 14.3m, 200));
        
        Console.WriteLine("Список всех продуктов:");
        inventory.DisplayAllProducts();
        
        var executionManager = inventory.CreateExecutionManager();
        Console.WriteLine($"\nОбщая стоимость продукции: {executionManager.CalculateTotalValue()} BYN");
        Console.WriteLine($"Средняя цена продукции: {executionManager.CalculateAveragePrice()} BYN");
        
        var maxPriceProduct = executionManager.GetMaxPrice();
        Console.WriteLine($"Продукт с максимальной ценой: {maxPriceProduct.Name} - {maxPriceProduct.Price} BYN");
        
        var minPriceProduct = executionManager.GetMinPrice();
        Console.WriteLine($"Продукт с минимальной ценой: {minPriceProduct.Name} - {minPriceProduct.Price} BYN");
    }
}