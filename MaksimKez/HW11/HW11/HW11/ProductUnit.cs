namespace HW11
{
    internal class ProductUnit : Product, IPricePerUnit
    {
        public int Quantity { get ; set; }
        public double PricePerUnit { get; set; }

        public ProductUnit()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of product units");
                if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0) continue;
                this.Quantity = quantity;
                break;
            }

            while (true)
            {
                Console.WriteLine("Enter item price per unit");
                if (!double.TryParse(Console.ReadLine(), out double pricePerUnit) || pricePerUnit <= 0) continue;
                this.PricePerUnit = pricePerUnit;
                break;
            }

            while (true)
            {
                Console.WriteLine("Enter product name");
                Name = Console.ReadLine();
                if (string.IsNullOrEmpty(Name)) continue;
                break; 
            }

            this.TotalPrice = CalculatePrice();
            this.ID = Guid.NewGuid().ToString();
        }

        public double CalculatePrice() => Quantity * PricePerUnit;

        public override string ToString()
        {
            return $"Product name {this.Name}. Total price of the product {this.TotalPrice} " +
                $"Price Per Unit {this.PricePerUnit}. Item Units {this.Quantity}";
        }
    }
}
