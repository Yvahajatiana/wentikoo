namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Address : EntityBase
    {
        public string Title { get; set; }

        public string SectionName { get; set; }

        public string StreetNumber { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string MoreExplanations { get; set; }

        public virtual ShippingAddress ShippingAddress { get; set; }
    }
}
