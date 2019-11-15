namespace Hashdji.Software.Infrastructure.Data.Maps
{
    using Hashdji.Software.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CustomerMap : EntityMap<Customer>
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityBuilder) 
            : base(entityBuilder)
        {
            entityBuilder.ToTable("customer");

            entityBuilder.Property(p => p.FirstName).HasColumnName("Firstname");
            entityBuilder.Property(p => p.LastName).HasColumnName("Lastname");
        }
    }
}
