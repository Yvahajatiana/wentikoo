namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Offer : EntityBase
    {
        public DateTime DepartureDate { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime ArrivalDate { get; set; }

        public float TotalWeight { get; set; }

        public float Price { get; set; }

        public string TransportType { get; set; }

        public string 
    }
}
