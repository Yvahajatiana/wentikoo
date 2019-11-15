namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Order : EntityBase
    {
        public ICollection<string> Items { get; set; }
    }
}
