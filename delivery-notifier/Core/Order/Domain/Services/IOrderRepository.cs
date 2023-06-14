using Core.Order.Domain.ReadModels;
using Utilities.Repository;

namespace Core.Order.Domain.Services
{
    public interface IOrderRepository : ICrudRepository
    {
        public OrderReadModel GetOrder(Guid id);
        public bool GetCurrentOrderByUserAndRestaurant(Guid restaurantId, Guid userId);
    }
}
