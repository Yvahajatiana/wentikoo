namespace Hashdji.Software.Infrastructure.Data.Maps
{
    using Hashdji.Software.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CarrierMap : EntityMap<Carrier>
    {
        public CarrierMap(EntityTypeBuilder<Carrier> entityBuilder) 
            : base(entityBuilder)
        {
            entityBuilder.ToTable("carrier");

            entityBuilder.Property(p => p.Name).HasColumnName("Name");
        }
    }
}
