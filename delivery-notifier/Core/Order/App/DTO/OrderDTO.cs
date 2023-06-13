using Core.Order.Domain.Model;
using Core.Order.Domain.ReadModels;

namespace Core.Order.App.DTO
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }
        public IList<DetailDTO> Details { get; set; }
        public SystemProvider SystemProvider { get; set; }

        private OrderDTO(Guid id, decimal total, DateTime created, IList<DetailDTO> details, SystemProvider systemProvider)
        {
            Id = id;
            Total = total;
            Created = created;
            Details = details;
            SystemProvider = systemProvider;
        }

        public static OrderDTO Of(OrderReadModel model)
        {
            return new OrderDTO(model.Id, model.Total, model.Created, model.Details.Select(DetailDTO.Of).ToList(), model.SystemProvider);
        }
    }
}
