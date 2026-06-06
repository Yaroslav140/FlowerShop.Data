namespace FlowerShop.Data.Models
{
    public class CartEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserDomain User { get; set; } = null!;
        public List<CartItemEntity> Items { get; set; } = [];
    }
}
