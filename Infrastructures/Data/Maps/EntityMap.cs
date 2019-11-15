namespace Hashdji.Software.Infrastructure.Data.Maps
{
    using Hashdji.Software.Core.Entities;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class EntityMap<T> where T : EntityBase
    {
        public EntityMap(EntityTypeBuilder<T> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.HasAlternateKey(p => p.UniqueId);
        }
    }
}
