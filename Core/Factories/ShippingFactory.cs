namespace Hashdji.Software.Core.Factories
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class ShippingFactory
    {
        public static void Map(this Shipping inDb, Shipping updated)
        {
            inDb.Coast = updated.Coast;
            inDb.CoastVat = updated.CoastVat;
            inDb.DeliveryDate = updated.DeliveryDate;
            inDb.EstimatedDeliveryDate = updated.EstimatedDeliveryDate;
            inDb.ProcessStarted = updated.ProcessStarted;
            inDb.ShippingDate = updated.ShippingDate;
        }
    }
}
