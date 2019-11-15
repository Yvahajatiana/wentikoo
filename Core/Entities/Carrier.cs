namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Carrier : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
