using Core.Order.Domain.Model;

namespace Core.Order.Domain.ReadModels
{
    public class OrderReadModel
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }
        public IList<DetailReadModel> Details { get; set; }
        public SystemProvider SystemProvider { get; set; }
        public DateTime EstimatedTime { get; set; }
    }
}
