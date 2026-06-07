using FlowerShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowerShop.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserDomain>
    {
        public void Configure(EntityTypeBuilder<UserDomain> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasMaxLength(256)
                   .IsRequired();
            builder.Property(u => u.Phone)
                   .HasMaxLength(15);
            builder.HasIndex(u => u.Email)
                   .IsUnique();

            builder.Property(u => u.PasswordHash)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.Property(u => u.DateRegistration)
                   .HasDefaultValueSql("NOW()");
            builder.Property(u => u.CodeOrder)
                   .HasMaxLength(10);

            builder.Property(u => u.EmailConfirmed)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.Property(u => u.EmailConfirmationToken)
                   .HasMaxLength(64);

            builder.Property(u => u.PendingEmail)
                   .HasMaxLength(256);

            builder.Property(u => u.EmailChangeToken)
                   .HasMaxLength(64);

            builder.Property(u => u.PasswordResetToken)
                   .HasMaxLength(64);

            builder.HasMany(u => u.Orders)
                   .WithOne(o => o.User)
                   .HasForeignKey(o => o.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
