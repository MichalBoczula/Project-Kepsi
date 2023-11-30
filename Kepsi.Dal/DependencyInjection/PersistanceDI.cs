using KeepItShort.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KeepItShort.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<KeepItShortContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("KeepItShort")));
            //services.AddScoped<IProductsContext, ProductsContext>();
            return services;
        }
    }
}
