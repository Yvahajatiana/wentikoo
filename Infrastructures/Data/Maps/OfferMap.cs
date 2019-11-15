namespace Hashdji.Software.Infrastructure.Data.Maps
{
    using Hashdji.Software.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OfferMap : EntityMap<Offer>
    {
        public OfferMap(EntityTypeBuilder<Offer> entityBuilder)
            :base(entityBuilder)
        {
            entityBuilder.ToTable("Offers");

            entityBuilder.Property(p => p.ArrivalDate).HasColumnName("ArrivalDate"); 
            entityBuilder.Property(p => p.Deadline).HasColumnName("Deadline");
            entityBuilder.Property(p => p.DepartureDate).HasColumnName("DepartureDate");
            entityBuilder.Property(p => p.Price).HasColumnName("Price");
            entityBuilder.Property(p => p.Seller).HasColumnName("Seller");
            entityBuilder.Property(p => p.TotalWeight).HasColumnName("TotalWeight");
            entityBuilder.Property(p => p.TransportType).HasColumnName("TransportType");
        }
    }
}
