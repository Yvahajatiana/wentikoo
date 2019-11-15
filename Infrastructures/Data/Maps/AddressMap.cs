namespace Hashdji.Software.Infrastructure.Data.Maps
{
    using Hashdji.Software.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class AddressMap : EntityMap<Address>
    {
        public AddressMap(EntityTypeBuilder<Address> entityBuilder)
            :base(entityBuilder)
        {
            entityBuilder.ToTable("address");

            entityBuilder.Property(p => p.Title).HasColumnName("Title");
            entityBuilder.Property(p => p.SectionName).HasColumnName("SectionName");
            entityBuilder.Property(p => p.StreetNumber).HasColumnName("StreetNumber");
            entityBuilder.Property(p => p.Street).HasColumnName("Street");
            entityBuilder.Property(p => p.City).HasColumnName("City");
            entityBuilder.Property(p => p.Region).HasColumnName("Region");
            entityBuilder.Property(p => p.MoreExplanations).HasColumnName("MoreExplanations");

            entityBuilder.HasOne(p => p.ShippingAddress).WithOne(p => p.Address).HasForeignKey<ShippingAddress>(p => p.AddressId);
        }
    }
}
