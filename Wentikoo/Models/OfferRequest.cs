namespace Hashdji.Software.Wentikoo.Models
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OfferRequest
    {
        public DateTime DepartureDate { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime ArrivalDate { get; set; }

        public float TotalWeight { get; set; }

        public float Price { get; set; }

        public string TransportType { get; set; }

        public Offer ToEntity()
        {
            return new Offer
            {
                ArrivalDate = ArrivalDate,
                Deadline = Deadline,
                DepartureDate = DepartureDate,
                Price = Price,
                TotalWeight = TotalWeight,
                TransportType = TransportType
            };
        }
    }
}
