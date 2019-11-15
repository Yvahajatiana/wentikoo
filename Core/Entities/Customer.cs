namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : EntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Shipping> Shippings { get; set; }
    }
}
