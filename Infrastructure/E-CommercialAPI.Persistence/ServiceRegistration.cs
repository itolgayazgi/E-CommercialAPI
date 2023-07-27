using Microsoft.EntityFrameworkCore;
using E_CommercialAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace E_CommercialAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services )
        {
            services.AddDbContext<E_CommercialAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
