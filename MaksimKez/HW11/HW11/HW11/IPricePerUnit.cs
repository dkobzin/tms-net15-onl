namespace HW11
{
    internal interface IPricePerUnit
    {
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }
        public double CalculatePrice();
    }
}
