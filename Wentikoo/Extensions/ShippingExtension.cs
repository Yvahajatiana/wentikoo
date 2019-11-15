namespace Hashdji.Software.Wentikoo.Extensions
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Wentikoo.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class ShippingExtension
    {
        public static IEnumerable<ShippingResponse> ToDtos(this IEnumerable<Shipping> entities)
        {
            if(entities == null || !entities.Any())
            {
                return Enumerable.Empty<ShippingResponse>();
            }

            return entities.Select(entity => entity.ToDto());
        }

        public static ShippingResponse ToDto(this Shipping entity)
        {
            var addresses = entity.Addresses == null || !entity.Addresses.Any() ?
                Enumerable.Empty<ShippingAddressResponse>() : entity.Addresses.Select(shAddress => 
                {
                    var location = string.Empty;
                    location = $"{shAddress?.Address?.City} - {shAddress?.Address?.Region}";

                    return new ShippingAddressResponse
                    {
                        Id = shAddress.UniqueId,
                        AddressId = (shAddress.Address == null) ? Guid.Empty : shAddress.UniqueId,
                        Location = location
                    };
                });

            return new ShippingResponse
            {
                Addresses = addresses,
                Coast = entity.Coast,
                CoastVat = entity.CoastVat,
                DeliveryDate = entity.DeliveryDate,
                EstimatedDeliveryDate = entity.EstimatedDeliveryDate,
                IsDelivered = entity.IsDelivered,
                ProcessStarted = entity.ProcessStarted,
                ShippingDate = entity.ShippingDate,
                CustomerId = (entity.Customer == null) ? Guid.Empty : entity.Customer.UniqueId,
                TripId = (entity.Trip == null) ? Guid.Empty : entity.Trip.UniqueId
            };
        }
    }
}
