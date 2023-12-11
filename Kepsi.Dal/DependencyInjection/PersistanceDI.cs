using KeepItShort.Persistance.Context;

using Kepsi.Bl.Interfaces;
using Kepsi.Bl.Queries;

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
            services.AddScoped<IDbManager, DbManager>();
            return services;
        }
    }
}
