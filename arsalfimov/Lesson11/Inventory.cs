using Newtonsoft.Json;

namespace Lesson11;
public class Inventory
{
    private List<Product> products;

    public Inventory() => products = new List<Product>();

    public void AddProduct(Product product) => products.Add(product);

    public void RemoveProduct(Guid id) => products.RemoveAll(p => p.ID == id);

    public List<Product> GetAllProducts() => products.ToList();

    public double GetTotalInventoryValue() => products.Sum(p => p.Price * p.Quantity);

    public double GetMaxPrice() => products.Max(p => p.Price);

    public double GetMinPrice() => products.Min(p => p.Price);

    public double GetAveragePrice() => products.Average(p => p.Price);

    public void SaveToFile(string filename)
    {
        string json = JsonConvert.SerializeObject(products);
        File.WriteAllText(filename, json);
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
        else
        {
            Console.WriteLine("The data file does not exist or is empty.");
        }
    }
}
