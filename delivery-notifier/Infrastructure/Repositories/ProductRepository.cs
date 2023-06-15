using Core.Product.Domain.Model;
using Core.Product.Domain.Services;
using Infrastructure.EntityFramework;
using Utilities.Repository;

namespace Infrastructure.Repositories
{
    public class ProductRepository : EntityFrameworkRepository<DeliveryNotifierContext>, IProductRepository
    {
        public ProductRepository(DeliveryNotifierContext context) : base(context)
        {
        }

        public IList<Product> GetProductsInList(IList<Guid> ids)
        {
            return dbContext.Products.Where(x => ids.Contains(x.Id)).ToList();
        }
    }
}
