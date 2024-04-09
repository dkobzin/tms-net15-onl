namespace Home_work11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product(1, "Product 1", 10.99m, 5);
            Product product2 = new Product(2, "Product 2", 5.99m, 10);


            Inventory inventory = new Inventory();


            inventory.AddProduct(product1);
            inventory.AddProduct(product2);


            ExecutionManager.DoInventory(inventory);
        }
    }
}
