using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace delivery_notifier.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static void AddEntityFrameworkServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DeliveryNotifierContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DbConnection"));
            });
        }
    }
}
