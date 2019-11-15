namespace Hashdji.Software.Wentikoo.Models
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class TripRequest
    {
        public Guid CarrierId { get; set; }

        public List<Guid> ShippingGuids { get; set; }

        public Trip ToEntity() => new Trip();
    }
}
