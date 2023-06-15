using Core.Order.Domain.Model;
using Core.Order.Domain.ReadModels;
using Core.Order.Domain.Services;
using Infrastructure.EntityFramework;
using Utilities.Exceptions;
using Utilities.Repository;

namespace Infrastructure.Repositories
{
    public class OrderRepository : EntityFrameworkRepository<DeliveryNotifierContext>, IOrderRepository
    {
        public OrderRepository(DeliveryNotifierContext context) : base(context)
        {
        }

        public OrderReadModel GetOrder(Guid id)
        {
            var query = from order in dbContext.Orders
                        where order.Id == id
                        select new OrderReadModel
                        {
                            Id = order.Id,
                            Total = order.Total,
                            Created = order.Created,
                            SystemProvider = order.SystemProvider,
                            EstimatedTime = order.EstimatedTime,
                            Details = (from detail in dbContext.Details
                                       join product in dbContext.Products on detail.ProductId equals product.Id
                                       where detail.OrderId == order.Id
                                        select new DetailReadModel
                                        {
                                            Id = detail.Id,
                                            ProductId = product.Id,
                                            ProductName = product.Name,
                                            ProductPrice = product.Price
                                        }).ToList()
                        };
            var result = query.FirstOrDefault();
            return result ?? throw new CustomException("Order not found");
        }

        public bool GetCurrentOrderByUserAndRestaurant(Guid restaurantId, Guid userId)
        {
            var query = from order in dbContext.Orders
                        where order.RestaurantId == restaurantId && order.UserId == userId && order.Status == OrderStatus.Placed
                        select order;
            return query.Any();
        }
    }
}
