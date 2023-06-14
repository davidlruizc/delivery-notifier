using Core.Restaurant.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.ToTable("Restaurant");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name)
                .IsRequired();
            builder.Property(p => p.Logo)
                .IsRequired();
            builder.Property(p => p.Created)
                .IsRequired();
        }
    }
}
