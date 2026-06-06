using FlowerShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop.Data
{
    public class FlowerDbContext(DbContextOptions<FlowerDbContext> options) : DbContext(options)
    {
        public DbSet<UserDomain> UserDomains => Set<UserDomain>();
        public DbSet<OrderEntity> Orders => Set<OrderEntity>();
        public DbSet<OrderItemEntity> OrderItems => Set<OrderItemEntity>();
        public DbSet<BouquetEntity> Bouquets => Set<BouquetEntity>();
        public DbSet<SoftToyEntity> SoftToys => Set<SoftToyEntity>();
        public DbSet<CartEntity> Carts => Set<CartEntity>();
        public DbSet<CartItemEntity> CartItems => Set<CartItemEntity>();
        public DbSet<FeedbackEntity> Feedbacks => Set<FeedbackEntity>();
        public DbSet<FeedbackItemEntity> FeedbackItems => Set<FeedbackItemEntity>();
        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            b.ApplyConfigurationsFromAssembly(typeof(FlowerDbContext).Assembly);
        }
    }
}
