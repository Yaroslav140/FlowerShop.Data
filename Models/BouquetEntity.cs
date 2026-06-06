namespace FlowerShop.Data.Models
{
    public class BouquetEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public float Rating { get; set; } = 0;
    }
}
