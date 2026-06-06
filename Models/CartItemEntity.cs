namespace FlowerShop.Data.Models
{
    public class CartItemEntity
    {
        public Guid Id { get; set; }

        public Guid CartId { get; set; }
        public CartEntity Cart { get; set; } = null!;

        public Guid? BouquetId { get; set; }
        public BouquetEntity Bouquet { get; set; }

        public Guid? SoftToyId { get; set; }
        public SoftToyEntity SoftToy { get; set; }

        public int Quantity { get; set; }
        public decimal PriceSnapshot { get; set; }
    }
}
