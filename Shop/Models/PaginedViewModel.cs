namespace Hashdji.Software.Shop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public abstract class PaginedViewModel
    {
        public int Page { get; set; }

        public int PageCount { get; set; }

        public string Route { get; set; }

    }
}
