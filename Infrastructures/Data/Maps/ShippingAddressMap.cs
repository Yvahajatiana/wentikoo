namespace Hashdji.Software.Infrastructure.Data.Maps
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ShippingAddressMap : EntityMap<ShippingAddress>
    {
        public ShippingAddressMap(EntityTypeBuilder<ShippingAddress> entityBuilder)
            :base(entityBuilder)
        {
            entityBuilder.ToTable("shipping_address");

            entityBuilder.Property(p => p.AddressType).HasColumnName("AddressType")
                .HasConversion(x => x.ToString(), v => (AddressType)Enum.Parse(typeof(AddressType), v));
            
            entityBuilder.HasOne(saddr => saddr.Shipping).WithMany(s => s.Addresses)
                .HasForeignKey(saddr => saddr.ShippingId);
            entityBuilder.HasOne(saddr => saddr.Address).WithOne(a => a.ShippingAddress)
                .HasForeignKey<ShippingAddress>(saddr => saddr.AddressId);
        }
    }
}
