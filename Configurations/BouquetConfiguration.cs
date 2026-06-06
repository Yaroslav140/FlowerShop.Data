using FlowerShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowerShop.Data.Configurations
{
    public class BouquetConfiguration : IEntityTypeConfiguration<BouquetEntity>
    {
        public void Configure(EntityTypeBuilder<BouquetEntity> builder)
        {
            builder.ToTable("Bouquets");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(b => b.Description)
                   .HasMaxLength(2000);

            builder.Property(b => b.Price)
                   .HasPrecision(18, 2);

            builder.Property(b => b.ImagePath)
                   .HasMaxLength(1024);

            builder.HasIndex(b => b.Name);

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Bouquets_Price_NonNegative", "\"Price\" >= 0");
                t.HasCheckConstraint("CK_Bouquets_Quantity_NonNegative", "\"Quantity\" >= 0");
            });
        }
    }
}
