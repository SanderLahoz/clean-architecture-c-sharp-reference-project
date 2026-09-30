
using Microsoft.Extensions.DependencyInjection;

namespace LeagueManager.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var currentAssembly = typeof(DependencyInjection).Assembly;
            
            return services;
        }
    }
}