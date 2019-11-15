namespace Hashdji.Software.Wentikoo.Models
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ShippingRequest
    {
        public float Coast { get; set; }

        public float CoastVat { get; set; }

        public DateTime ShippingDate { get; set; }

        public Guid DepartureAddress { get; set; }

        public Guid DestinationAddress { get; set; }

        public Shipping CreateShipping()
        {
            return new Shipping
            {
                Coast = Coast,
                CoastVat = CoastVat,
                ShippingDate = ShippingDate
            };
        }
    }
}
