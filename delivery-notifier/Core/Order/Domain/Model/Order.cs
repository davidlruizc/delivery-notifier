using Utilities.Domain;

namespace Core.Order.Domain.Model
{
    public class Order : BaseEntity
    {
        public Guid ProductId { get; set; }
        public SystemProvider SystemProvider { get; set; }
        public Guid UserId { get; set; }

        private Order(Guid id, Guid productId, SystemProvider systemProvider, Guid userId)
        {
            Id = id;
            ProductId = productId;
            SystemProvider = systemProvider;
            UserId = userId;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Order Of(Guid id, Guid productId, SystemProvider systemProvider, Guid userId)
        {
            return new Order(id, productId, systemProvider, userId);
        }
    }
}
