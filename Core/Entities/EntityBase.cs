namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class EntityBase
    {
        public int Id { get; set; }

        public Guid UniqueId { get; set; }
    }
}
