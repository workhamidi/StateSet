using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace StateSet.IoC.Bll
{
    public static class DependenciesInjections
    {
        public static IServiceCollection BllDependenciesInjections(
            this IServiceCollection services,
            IConfiguration configuration
            )
        {


            return services;
        }
    }
}
