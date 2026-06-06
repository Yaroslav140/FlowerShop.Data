using FlowerShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowerShop.Data.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItemEntity>
    {
        public void Configure(EntityTypeBuilder<CartItemEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantity)
                   .IsRequired();

            builder.Property(x => x.PriceSnapshot)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.HasOne(x => x.Bouquet)
                   .WithMany()
                   .HasForeignKey(x => x.BouquetId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.SoftToy)
                   .WithMany()
                   .HasForeignKey(x => x.SoftToyId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Cart)
                   .WithMany(c => c.Items)
                   .HasForeignKey(x => x.CartId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
