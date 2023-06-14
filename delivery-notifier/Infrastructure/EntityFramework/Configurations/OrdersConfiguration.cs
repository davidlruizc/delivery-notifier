using Core.Order.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class OrdersConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Created).IsRequired();
            builder.Property(p => p.SystemProvider).IsRequired();
            builder.Property(p => p.RestaurantId).IsRequired();
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.EstimatedTime).IsRequired();
            builder.Property(p => p.Total).IsRequired();
        }   
    }
}
