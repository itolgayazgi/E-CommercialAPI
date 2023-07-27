using Microsoft.EntityFrameworkCore;
using E_CommercialAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using E_CommercialAPI.Application.Repositories;
using E_CommercialAPI.Persistence.Repositories;

namespace E_CommercialAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services )
        {
            services.AddDbContext<E_CommercialAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString), ServiceLifetime.Singleton);
            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
