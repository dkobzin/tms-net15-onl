namespace Lesson11;

public static class ProductHandler
{
    public static Product AddProduct(Inventory inventory)
    {
        string name = ReadProductName(inventory);
        double price = ReadProductPrice();
        int quantity = ReadProductQuantity();

        Guid id = Guid.NewGuid();
        Product product = new(name, price, quantity, id);
        inventory.AddProduct(product);
        Console.WriteLine("The product has been successfully added to the inventory.");
        return product;
    }

    public static void RemoveProduct(Inventory inventory)
    {
        Guid id = ReadProductId();
        if (inventory.GetAllProducts().Exists(p => p.ID == id))
        {
            inventory.RemoveProduct(id);
            Console.WriteLine("The product has been successfully removed from the inventory.");
        }
        else
        {
            Console.WriteLine("The product with the specified ID was not found.");
        }
    }

    public static void PrintTotalValue(Inventory inventory)
    {
        Console.WriteLine($"The sum of all products: {inventory.GetTotalInventoryValue()}");
    }

    public static void PrintMaxPrice(Inventory inventory)
    {
        Console.WriteLine($"Maximum product price: {inventory.GetMaxPrice()}");
    }

    public static void PrintMinPrice(Inventory inventory)
    {
        Console.WriteLine($"Minimum product price: {inventory.GetMinPrice()}");
    }

    public static void PrintAveragePrice(Inventory inventory)
    {
        Console.WriteLine($"Average product price: {inventory.GetAveragePrice()}");
    }

    public static void PrintAllProducts(Inventory inventory)
    {
        List<Product> sortedProducts = inventory.GetAllProducts();
        sortedProducts.Sort();
        Console.WriteLine("\nList of all products:");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"ID: {product.ID}\tTitle: {product.Name,-18} Price: {product.Price,-10} Quantity: {product.Quantity,-10}");
        }
    }

    private static string ReadProductName(Inventory inventory)
    {
        string name;
        do
        {
            Console.Write("Enter the product name: ");
            name = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("The product name cannot be empty. Please try again.");
                continue;
            }

            if (inventory.GetAllProducts().Exists(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"A product with the name '{name}' already exists. Please enter a different name.");
                continue;
            }
            break;
        } while (true);

        return name;
    }

    private static double ReadProductPrice()
    {
        double price;
        do
        {
            Console.Write("Enter the product price: ");
        } while (!double.TryParse(Console.ReadLine(), out price) || price <= 0);
        return price;
    }

    private static int ReadProductQuantity()
    {
        int quantity;
        do
        {
            Console.Write("Enter the product quantity: ");
        } while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0);
        return quantity;
    }

    private static Guid ReadProductId()
    {
        Guid id;
        bool isValidId;
        do
        {
            Console.Write("Enter the product ID to delete: ");
            isValidId = Guid.TryParse(Console.ReadLine(), out id);
            if (!isValidId)
            {
                Console.WriteLine("Invalid ID format. Try again.");
            }
        } while (!isValidId);
        return id;
    }
}
