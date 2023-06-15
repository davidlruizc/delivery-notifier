using Core.Product.Domain.Services;
using Infrastructure.Repositories;

namespace delivery_notifier.Extensions
{
    public static class ProductExtension
    {
        public static void AddProductServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
