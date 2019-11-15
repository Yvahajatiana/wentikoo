namespace Hashdji.Software.Infrastructure.Data.Maps
{
    using Hashdji.Software.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TripMap : EntityMap<Trip>
    {
        public TripMap(EntityTypeBuilder<Trip> entityBuilder) 
            : base(entityBuilder)
        {
            entityBuilder.ToTable("trip");

            entityBuilder.HasOne(tr => tr.Carrier).WithMany(x => x.Trips).HasForeignKey(x => x.CarrierId);
        }
    }
}
