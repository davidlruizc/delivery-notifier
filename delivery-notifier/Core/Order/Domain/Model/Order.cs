using Core.Product.Domain.Model;
using Core.Product.Domain.Services;
using Utilities.Domain;

namespace Core.Order.Domain.Model
{
    public class Order : BaseEntity
    {
        public Guid RestaurantId { get; set; }
        public SystemProvider SystemProvider { get; set; }
        public Guid UserId { get; set; }
        public IList<Detail> Details { get; set; }
        public decimal Total { get; set; }

        private Order(Guid id, Guid restaurantId, SystemProvider systemProvider, Guid userId, IList<Detail> details, decimal total)
        {
            Id = id;
            RestaurantId = restaurantId;
            SystemProvider = systemProvider;
            UserId = userId;
            Details = details;
            Total = total;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Order Of(Guid id, Guid restaurantId, SystemProvider systemProvider, Guid userId, IList<Detail> details, IProductRepository productRepository)
        {
            var totalCalculated = CalculateTotal(details, productRepository);
            return new Order(id, restaurantId, systemProvider, userId, details, totalCalculated);
        }

        public static decimal CalculateTotal(IList<Detail> details, IProductRepository productRepository)
        {
            var productIds = details.GroupBy(x => x.ProductId).Select(x => x.First().ProductId).ToList();
            var products = productRepository.GetProductsInList(productIds);
            return NetTotal(products);
        }

        public static decimal NetTotal(IList<Product.Domain.Model.Product> products)
        {
            decimal total = 0;
            total = products.Sum(x => x.Price);
            return total;
        }
    }
}
