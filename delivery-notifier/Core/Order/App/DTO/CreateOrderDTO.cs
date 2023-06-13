using Core.Order.Domain.Model;
using Core.Product.Domain.Services;

namespace Core.Order.App.DTO
{
    public class CreateOrderDTO
    {
        public IList<Guid> ProductIds { get; set; }
        public SystemProvider SystemProvider { get; set; }
        public Guid UserId { get; set; }
        public Guid RestaurantId { get; set; }
        public OrderStatus Status { get; set; }
        public double EstimatedTime { get; set; }

        public Domain.Model.Order ToModel(IProductRepository productRespository)
        {
            var orderId = Guid.NewGuid();
            var details = new List<Detail>();
            foreach (var productId in ProductIds)
            {
                var product = productRespository.FindOrFail<Product.Domain.Model.Product>(productId);
                details.Add(Detail.Of(Guid.NewGuid(), product.Id, orderId));
            }
            return Domain.Model.Order.Of(orderId, RestaurantId, SystemProvider, UserId, details, productRespository, Status, EstimatedTime);
        }
    }
}
