namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Trip : EntityBase
    {
        public virtual ICollection<Shipping> Shippings { get; set; }

        public virtual Carrier Carrier { get; set; }

        public int CarrierId { get; set; }
    }
}
