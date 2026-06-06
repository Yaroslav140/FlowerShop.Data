using FlowerShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowerShop.Data.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItemEntity>
    {
        public void Configure(EntityTypeBuilder<OrderItemEntity> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Quantity).IsRequired();
            builder.Property(i => i.Price).HasColumnType("numeric(18,2)").IsRequired();

            builder.HasIndex(i => i.OrderId);
            builder.HasIndex(i => i.BouquetId);
            builder.HasIndex(i => i.SoftToyId);

            builder.HasOne(i => i.Order)
                   .WithMany(o => o.Items)
                   .HasForeignKey(i => i.OrderId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(i => i.Bouquet)
                   .WithMany()
                   .HasForeignKey(i => i.BouquetId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(i => i.SoftToy)
                   .WithMany()
                   .HasForeignKey(i => i.SoftToyId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
