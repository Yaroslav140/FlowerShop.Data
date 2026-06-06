using FlowerShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowerShop.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.PickupDate)
                   .HasColumnType("timestamp with time zone");

            builder.Property(o => o.TotalAmount)
                   .HasPrecision(18, 2)
                   .IsRequired();

            builder.Property(o => o.Status)
                   .HasConversion<string>()
                   .HasMaxLength(32);

            builder.HasIndex(o => o.UserId);
            builder.HasMany(o => o.Items)
                   .WithOne(i => i.Order)
                   .HasForeignKey(i => i.OrderId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
