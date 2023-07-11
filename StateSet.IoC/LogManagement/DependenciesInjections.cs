using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StateSet.Dal.Context;

namespace StateSet.IoC.LogManagement
{
    public static class DependenciesInjections
    {
        public static IServiceCollection LogManagementDependenciesInjections(
            this IServiceCollection services)
        {
            
            services.AddSingleton<
                StateSet.LogManager.ILog,
                StateSet.LogManager.SeriLogManagement.SerilogLogger
            >();
            
            return services;
        }
    }
}
