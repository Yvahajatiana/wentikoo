namespace Hashdji.Software.Infrastructure.Data
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Infrastructure.Data.Maps;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new OfferMap(modelBuilder.Entity<Offer>());
            new AddressMap(modelBuilder.Entity<Address>());
            new ShippingMap(modelBuilder.Entity<Shipping>());
            new ShippingAddressMap(modelBuilder.Entity<ShippingAddress>());
            new TripMap(modelBuilder.Entity<Trip>());
            new CarrierMap(modelBuilder.Entity<Carrier>());
            new CustomerMap(modelBuilder.Entity<Customer>());
        }
    }
}
