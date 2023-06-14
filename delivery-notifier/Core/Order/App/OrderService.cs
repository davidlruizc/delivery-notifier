using Core.Order.App.DTO;
using Core.Order.Domain.Services;
using Core.Product.Domain.Services;
using Utilities;

namespace Core.Order.App
{
    public class OrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
        }

        public OrderDTO CreateOrder(CreateOrderDTO dto)
        {
            var model = dto.ToModel(productRepository);
            model.Initialize();
            var findOrderCreated = orderRepository.GetCurrentOrderByUserAndRestaurant(model.RestaurantId, model.UserId);
            Guards.Require(findOrderCreated, "You already have an order placed.");
            orderRepository.Save(model);
            foreach (var detail in model.Details)
            {
                detail.Initialize();
                orderRepository.Save(detail);
            }
            orderRepository.CommitChanges();
            return OrderDTO.Of(orderRepository.GetOrder(model.Id));
        }

        public OrderDTO EditStatusOrder(EditStatusOrderDTO dto)
        {
            var existent = orderRepository.FindOrFail<Domain.Model.Order>(dto.OrderId);
            existent.Status = dto.Status;
            orderRepository.Save(existent);
            orderRepository.CommitChanges();
            return OrderDTO.Of(orderRepository.GetOrder(existent.Id));
        }
    }
}
