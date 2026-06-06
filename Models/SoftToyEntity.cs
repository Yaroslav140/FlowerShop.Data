namespace FlowerShop.Data.Models
{
    public class SoftToyEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public float Rating { get; set; } = 0;
    }
}
