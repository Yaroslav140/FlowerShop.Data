namespace FlowerShop.Data.Models
{
    public class FeedbackEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserDomain User { get; set; }
        public Guid? OrderId { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.UtcNow;
        public string Description { get; set; } = string.Empty;

        public float StoreRating { get; set; }
        public List<FeedbackItemEntity> FeedbackItems { get; set; } = [];
    }
}
