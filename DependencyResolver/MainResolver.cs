namespace Hashdji.Software.DependencyResolver
{
    using Hashdji.Software.DependencyResolver.Resolvers;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class MainResolver
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.ConfigureServices();
            services.ConfigureRepositories();
        }
    }
}
