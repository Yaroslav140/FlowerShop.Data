namespace FlowerShop.Data.Models
{
    public class UserDomain
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime DateRegistration { get; set; }
        public string CodeOrder { get; set; } = string.Empty;
        public List<OrderEntity> Orders { get; set; } = [];
    }
}
