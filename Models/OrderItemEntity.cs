namespace FlowerShop.Data.Models
{
    public class OrderItemEntity
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }

        public Guid? BouquetId { get; set; }
        public Guid? SoftToyId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public string? ImageUrlSnapshot { get; set; }

        public OrderEntity Order { get; set; } = default!;
        public BouquetEntity? Bouquet { get; set; }
        public SoftToyEntity? SoftToy { get; set; }
    }
}
