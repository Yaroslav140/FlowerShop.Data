namespace FlowerShop.Data.Models
{
    public class FeedbackItemEntity
    {
        public Guid Id { get; set; }

        public Guid FeedbackId { get; set; }
        public FeedbackEntity Feedback { get; set; }

        public int ProductRating { get; set; }
        public string Comment { get; set; } = string.Empty;

        public Guid? BouquetId { get; set; }
        public BouquetEntity? Bouquet { get; set; }

        public Guid? SoftToyId { get; set; }
        public SoftToyEntity? SoftToy { get; set; }
    }
}
