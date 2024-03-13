namespace HW11
{
    internal class ProductWeight : Product, IPricePerWeight
    {
        public double Weight { get; set; }
        public double PricePerKilo { get; set; }
        public ProductWeight()
        {
            while (true)
            {
                Console.WriteLine("Enter the weight of the product");
                if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0) continue;
                this.Weight = weight;
                break;
            }
            while (true)
            {
                Console.WriteLine("Enter the price per kg of product");
                if (!double.TryParse(Console.ReadLine(), out double pricePerKilo) || pricePerKilo <= 0) continue;
                this.PricePerKilo = pricePerKilo;
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

        public double CalculatePrice() => Weight * PricePerKilo;
        public override string ToString()
        {
            return $"Product name {this.Name}. Total price of the product {this.TotalPrice} " +
                $"Price per unit {this.PricePerKilo}. Product units {this.Weight}";
        }

    }
}
