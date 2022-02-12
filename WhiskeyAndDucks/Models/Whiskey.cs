namespace WhiskeyAndDucks.Models
{
    public class Whiskey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Proof { get; set; }
        public int StockQuantity { get; set; }
        public bool InStock { get => StockQuantity > 0; }
    }
}
