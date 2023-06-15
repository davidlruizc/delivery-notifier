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
            builder.HasData(new Product
            {
                Id = Guid.Parse("357a5f62-89f9-4e68-80e1-a94be2fc06d3"),
                Name = "Cheese Burger",
                Image = "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=999&q=80",
                Price = 10.99m,
                Created = new DateTime(2023, 3, 28),
            },
            new Product
            {
                Id = Guid.Parse("357a5f62-89f9-4e68-80e1-a94be2fc06d4"),
                Name = "Hot Dog",
                Image = "https://images.unsplash.com/photo-1599599810694-b5b37304c041?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=627&q=80",
                Price = 5.99m,
                Created = new DateTime(2023, 3, 28),
            });
        }
    }
}
