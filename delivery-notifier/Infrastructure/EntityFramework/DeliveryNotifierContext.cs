using Core.Order.Domain.Model;
using Core.Product.Domain.Model;
using Core.Restaurant.Domain.Model;
using Core.Users.Domain.Model;
using Infrastructure.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework
{
    public class DeliveryNotifierContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Users> Users { get; set; }

        public DeliveryNotifierContext() { }
        public DeliveryNotifierContext(DbContextOptions<DeliveryNotifierContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
