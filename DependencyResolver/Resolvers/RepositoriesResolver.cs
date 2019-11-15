namespace Hashdji.Software.DependencyResolver.Resolvers
{
    using Hashdji.Software.Core.Interfaces.Repositories;
    using Hashdji.Software.Core.Interfaces.Services;
    using Hashdji.Software.Core.Services;
    using Hashdji.Software.Infrastructure.Data.Repositories;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class RepositoriesResolver
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<IOfferRepository, OfferRepository>();
            services.AddTransient<IShippingRepository, ShippingRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IShippingAddressRepository, ShippingAddressRepository>();
            services.AddTransient<ITripRepository, TripRepository>();
            services.AddTransient<ICarrierRepository, CarrierRepository>();
        }
    }
}
