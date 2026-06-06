namespace FlowerShop.Data.Models
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime PickupDate { get; set; }
        public string? DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.New;
        public UserDomain User { get; set; } = null!;
        public bool CanReview { get; set; } = false;
        public List<OrderItemEntity> Items { get; set; } = new();
    }

    public enum OrderStatus
    {
        New,
        Pending,
        InProgress,
        Completed,
        Cancelled
    }
}
