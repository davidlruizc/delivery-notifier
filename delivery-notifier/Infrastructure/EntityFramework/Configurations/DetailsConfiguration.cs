using Core.Order.Domain.Model;
using Core.Product.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class DetailsConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder.ToTable("Details");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.OrderId).IsRequired();
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.Created).IsRequired();
            builder.HasOne<Product>().WithMany().HasForeignKey(x => x.ProductId);
        }
    }
}
