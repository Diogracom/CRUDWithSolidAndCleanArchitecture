using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService
            ( this IServiceCollection services)
        {
            return services;
        }
    }
}
