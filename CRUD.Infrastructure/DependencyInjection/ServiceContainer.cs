using CRUD.Domain.RepositoryInterface;
using CRUD.Infrastructure.DataAccess;
using CRUD.Infrastructure.RepositoryImplemetation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore; 

namespace CRUD.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService
            ( this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext> (
                o => o.UseSqlServer(config.GetConnectionString("cleanArchitectureDb")));

            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
