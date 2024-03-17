namespace Lesson11
{
    public class Product(string name, double price, int quantity, Guid id) : IComparable<Product>
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;
        public Guid ID { get; set; } = id;
        public int Quantity { get; set; } = quantity;

        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return this.Name.CompareTo(other.Name);
        }
    }
}
