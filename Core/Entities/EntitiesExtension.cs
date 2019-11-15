namespace Hashdji.Software.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class EntitiesExtension
    {
        public static void Map(this Offer offer, Offer newOffer)
        {
            offer.ArrivalDate = newOffer.ArrivalDate;
            offer.Deadline = newOffer.Deadline;
            offer.DepartureDate = newOffer.DepartureDate;
            offer.Price = newOffer.Price;
            offer.Seller = newOffer.Seller;
            offer.TotalWeight = newOffer.TotalWeight;
            offer.TransportType = newOffer.TransportType;
        }
    }
}
