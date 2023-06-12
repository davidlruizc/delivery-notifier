using Utilities.Domain;

namespace Core.Order.Domain.Model
{
    public class Order : BaseEntity
    {
        public Guid RestaurantId { get; set; }
        public SystemProvider SystemProvider { get; set; }
        public Guid UserId { get; set; }
        public IList<Detail> Details { get; set; }

        private Order(Guid id, Guid restaurantId, SystemProvider systemProvider, Guid userId, IList<Detail> details)
        {
            Id = id;
            RestaurantId = restaurantId;
            SystemProvider = systemProvider;
            UserId = userId;
            Details = details;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Order Of(Guid id, Guid restaurantId, SystemProvider systemProvider, Guid userId, IList<Detail> details)
        {
            return new Order(id, restaurantId, systemProvider, userId, details);
        }
    }
}
