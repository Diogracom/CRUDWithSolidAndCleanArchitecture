using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrustructureService
            ( this IServiceCollection services)
        {
            return services;
        }
    }
}
