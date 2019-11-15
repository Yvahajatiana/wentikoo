namespace Hashdji.Software.Wentikoo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ShippingStartRequest
    {
        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }
    }
}
