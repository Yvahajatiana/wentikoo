using Hashdji.Software.Core.Interfaces.Repositories;
using Hashdji.Software.Core.Interfaces.Services;
using Hashdji.Software.Core.Services;
using Hashdji.Software.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashdji.Software.DependencyResolver.Resolvers
{
    public static class ServicesResolver
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IOfferService, OfferService>();
            services.AddTransient<IShippingService, ShippingService>();
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<ITripService, TripService>();
            services.AddTransient<ICarrierService, CarrierService>();
        }
    }
}
