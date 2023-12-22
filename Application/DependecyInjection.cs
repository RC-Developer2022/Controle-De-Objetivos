using Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependecyInjection
{
    public static IServiceCollection AddCoreApplication(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddCoreInfrastructure(configuration);
        return services;
    }
}
