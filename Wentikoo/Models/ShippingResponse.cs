namespace Hashdji.Software.Wentikoo.Models
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ShippingResponse
    {
        public virtual IEnumerable<ShippingAddressResponse> Addresses { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        public DateTime ShippingDate { get; set; }

        public float Coast { get; set; }

        public float CoastVat { get; set; }

        public bool ProcessStarted { get; set; }

        public bool IsDelivered { get; set; }

        public Guid TripId { get; set; }

        public Guid CustomerId { get; set; }
    }

    public class ShippingAddressResponse
    {
        public Guid Id { get; set; }

        public Guid AddressId { get; set; }

        public string Location { get; set; }
    }
}
