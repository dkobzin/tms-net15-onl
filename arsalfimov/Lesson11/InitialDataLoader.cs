namespace Lesson11;
class InitialDataLoader(string filename)
{
    private readonly string filename = filename;

    public void LoadInitialData(Inventory inventory)
    {
        if (!File.Exists(filename))
        {
            AddInitialData(inventory);
        }
        else
        {
            FileInfo fileInfo = new(filename);
            if (fileInfo.Length == 0)
            {
                AddInitialData(inventory);
            }
            else
            {
                inventory.LoadFromFile(filename);
            }
        }
    }

    private void AddInitialData(Inventory inventory)
    {
        List<Product> initialProducts =
        [
            new Product("Table", 12.75, 25, Guid.NewGuid()),
            new Product("Bed", 30.00, 10, Guid.NewGuid()),
            new Product("Desk", 18.50, 20, Guid.NewGuid()),
            new Product("Lamp", 8.75, 50, Guid.NewGuid()),
            new Product("Bookshelf", 22.00, 15, Guid.NewGuid()),
            new Product("TV Stand", 45.25, 5, Guid.NewGuid()),
            new Product("Coffee Table", 25.00, 30, Guid.NewGuid()),
            new Product("Dining Table", 60.25, 8, Guid.NewGuid()),
            new Product("Nightstand", 17.75, 12, Guid.NewGuid()),
            new Product("Cabinet", 40.50, 18, Guid.NewGuid())
        ];

        foreach (var product in initialProducts)
        {
            inventory.AddProduct(product);
        }

        inventory.SaveToFile(filename);
    }
}
