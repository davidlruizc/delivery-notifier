using Core.Product.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Created).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Image).IsRequired();
            builder.Property(p => p.Price).IsRequired();
        }
    }
}
