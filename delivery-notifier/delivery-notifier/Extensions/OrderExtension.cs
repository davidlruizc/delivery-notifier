using Core.Order.App;
using Core.Order.Domain.Services;
using Infrastructure.Repositories;

namespace delivery_notifier.Extensions
{
    public static class OrderExtension
    {
        public static void AddOrderServices(this IServiceCollection services)
        {
            services.AddScoped<OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
