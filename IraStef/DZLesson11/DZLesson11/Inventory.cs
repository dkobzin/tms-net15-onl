namespace DZLesson11
{
    public class Inventory
    {
        public delegate Store CreateProductAction();
        public delegate void DeleteProductAction();
        public event DeleteProductAction? onDelete;
        public List<Store> listStore;

        public Inventory(DeleteProductAction eventAction)

        {    
            this.onDelete = eventAction;
            listStore = new List<Store>();
        }
        public void Add(Store obj)
        {
            listStore.Add(obj);
        }
        public void PrintStore()
        {
            Console.WriteLine("List of products in the store:\n");
            listStore.ForEach(i => Console.WriteLine($"{i.id} - {i.name}, count: {i.count}, price: {i.price} р."));
        }

        public void AddProduct(CreateProductAction action)
        {
            listStore.Add(action());
        }
        public void RemoveProduct()
        {
            Console.WriteLine("Enter id of product:");
            int id = int.Parse(Console.ReadLine());

            if (listStore.RemoveAll(p => p.id == id) > 0)
            {
                onDelete?.Invoke();
            }
            else
            {
                Console.WriteLine("Unknown id of product:");
            }
        }
    }
}
