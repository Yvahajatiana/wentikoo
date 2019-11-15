namespace Hashdji.Software.Wentikoo.Extensions
{
    using Hashdji.Software.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class ServiceExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["mysqlconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(options => options.UseLazyLoadingProxies().UseMySql(connectionString));
        }
    }
}
