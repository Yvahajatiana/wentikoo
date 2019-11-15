namespace Hashdji.Software.Core.Entities
{
    using Hashdji.Software.Core.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ShippingAddress : EntityBase
    {
        public int ShippingId { get; set; }

        public virtual Shipping Shipping { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public AddressType AddressType { get; set; }
    }
}
