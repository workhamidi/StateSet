using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StateSet.Dal.Context;

namespace StateSet.IoC.Dal
{
    public static class DependenciesInjections
    {
        public static IServiceCollection DalDependenciesInjections(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {

            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<StateSetContext>(options =>
                    options.UseInMemoryDatabase("StateSetInMemory"));
            }
            else
            {
                services.AddDbContext<StateSetContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            }
            



            return services;
        }
    }
}
