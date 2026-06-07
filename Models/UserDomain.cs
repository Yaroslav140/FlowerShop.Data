namespace FlowerShop.Data.Models
{
    public class UserDomain
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime DateRegistration { get; set; }
        public string CodeOrder { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } = false;
        public string? EmailConfirmationToken { get; set; }
        public string? PendingEmail { get; set; }
        public string? EmailChangeToken { get; set; }
        public string? PasswordResetToken { get; set; }
        public DateTime? PasswordResetTokenExpiry { get; set; }
        public List<OrderEntity> Orders { get; set; } = [];
    }
}
