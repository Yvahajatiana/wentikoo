namespace Hashdji.Software.Infrastructure.Data.Maps
{
    using Hashdji.Software.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ShippingMap : EntityMap<Shipping>
    {
        public ShippingMap(EntityTypeBuilder<Shipping> entityBuilder)
            :base(entityBuilder)
        {
            entityBuilder.ToTable("shipping");

            entityBuilder.Property(p => p.Coast).HasColumnName("Coast");
            entityBuilder.Property(p => p.CoastVat).HasColumnName("CoastVat");
            entityBuilder.Property(p => p.DeliveryDate).HasColumnName("DeliveryDate");
            entityBuilder.Property(p => p.EstimatedDeliveryDate).HasColumnName("EstimatedDeliveryDate");
            entityBuilder.Property(p => p.ProcessStarted).HasColumnName("ProcessStarted");
            entityBuilder.Property(p => p.ShippingDate).HasColumnName("ShippingDate");
            entityBuilder.Property(p => p.IsDelivered).HasColumnName("IsDelivered");

            entityBuilder.HasOne(sh => sh.Trip).WithMany(tr => tr.Shippings).HasForeignKey(sh => sh.TripId);
            entityBuilder.HasOne(sh => sh.Customer).WithMany(cu => cu.Shippings).HasForeignKey(sh => sh.CustomerId);

        }
    }
}
