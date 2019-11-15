namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Shipping : EntityBase
    {
        //public virtual Order Order { get; set; }

        public virtual ICollection<ShippingAddress> Addresses { get; set; }

        //public virtual ICollection<string> Logs { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        public DateTime ShippingDate { get; set; }

        public float Coast { get; set; }

        public float CoastVat { get; set; }

        public bool ProcessStarted { get; set; }

        public bool IsDelivered { get; set; }

        public virtual Trip Trip { get; set; }

        public int TripId { get; set; }

        public virtual Customer Customer { get; set; }

        public int CustomerId { get; set; }
    }
}
