using Core.Order.Domain.Model;

namespace Core.Order.App.DTO
{
    public class EditStatusOrderDTO
    {
        public Guid OrderId { get; set; }
        public OrderStatus Status { get; set; }
    }
}
