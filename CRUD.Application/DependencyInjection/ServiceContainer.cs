using CRUD.Application.MappingImplementation;
using CRUD.Application.MappingInterface;
using CRUD.Application.UseCaseImplementation;
using CRUD.Application.UseCaseInterface;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService
            ( this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductMapper, ProductMapper>();
            return services;
        }
    }
}
