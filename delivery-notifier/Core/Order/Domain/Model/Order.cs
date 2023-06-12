using Utilities.Domain;

namespace Core.Order.Domain.Model
{
    public class Order : BaseEntity
    {
        public Guid ProductId { get; set; }
        public int SystemProvider { get; set; }

        private Order(Guid id, Guid productId, int systemProvider)
        {
            Id = id;
            ProductId = productId;
            SystemProvider = systemProvider;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Order Of(Guid id, Guid productId, int systemProvider)
        {
            return new Order(id, productId, systemProvider);
        }
    }
}
