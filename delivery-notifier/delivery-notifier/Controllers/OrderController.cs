using Core.Order.App;
using Core.Order.App.DTO;
using Microsoft.AspNetCore.Mvc;

namespace delivery_notifier.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost("create-order")]
        public OrderDTO CreateOrder(CreateOrderDTO dto)
        {
            return orderService.CreateOrder(dto);
        }

        [HttpPost("edit-status-order")]
        public OrderDTO EditStatusOrder(EditStatusOrderDTO dto)
        {
            return orderService.EditStatusOrder(dto);
        }
    }
}
