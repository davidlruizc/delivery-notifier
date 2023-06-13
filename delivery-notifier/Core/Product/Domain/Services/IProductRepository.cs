using Utilities.Repository;

namespace Core.Product.Domain.Services
{
    public interface IProductRepository : ICrudRepository
    {
        public IList<Model.Product> GetProductsInList(IList<Guid> ids);
    }
}
