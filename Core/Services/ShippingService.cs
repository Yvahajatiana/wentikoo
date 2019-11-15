namespace Hashdji.Software.Core.Services
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Enums;
    using Hashdji.Software.Core.Exceptions;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using Hashdji.Software.Core.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ShippingService : IShippingService
    {
        private readonly IShippingRepository shippingRepository;
        private readonly IShippingAddressRepository shippingAddressRepository;
        private readonly IAddressRepository addressRepository;

        public ShippingService(
            IShippingRepository shippingRepository, 
            IShippingAddressRepository shippingAddressRepository,
            IAddressRepository addressRepository)
        {
            this.shippingRepository = shippingRepository;
            this.shippingAddressRepository = shippingAddressRepository;
            this.addressRepository = addressRepository;
        }

        public async Task<Shipping> GetShipping(Guid guid)
        {
            return await shippingRepository.GetShipping(guid);
        }

        public async Task<IEnumerable<Shipping>> GetShippingsAsync()
        {
            return await shippingRepository.GetShippings();
        }

        public async Task Create(Shipping shipping)
        {
            await shippingRepository.Create(shipping);
            await shippingRepository.SaveAsync();
        }

        public async Task Delete(Guid guid)
        {
            var shipping = await shippingRepository.GetShipping(guid);
            await shippingRepository.DeleteShipping(shipping);
            await shippingRepository.SaveAsync();
        }

        public async Task<Shipping> StartShipping(Guid guid, Shipping data)
        {
            var shipping = await shippingRepository.GetShipping(guid);
            if(shipping == null)
            {
                shippingNotFound(guid);
            }

            shipping.ProcessStarted = true;
            shipping.ShippingDate = data.ShippingDate;
            shipping.EstimatedDeliveryDate = data.EstimatedDeliveryDate;
            await shippingRepository.UpdateShipping(shipping);

            return await shippingRepository.GetShipping(guid);
        }

        public async Task<Shipping> DeliveryShipping(Guid guid)
        {
            var shipping = await shippingRepository.GetShipping(guid);
            if (shipping == null)
            {
                shippingNotFound(guid);
            }

            shipping.DeliveryDate = DateTime.UtcNow;
            await shippingRepository.UpdateShipping(shipping);

            return await shippingRepository.GetShipping(guid);
        }

        private void shippingNotFound(Guid guid)
        {
            throw new NotFoundException($"shipping with id {guid}");
        }

        public async Task AddAddresses(Shipping shipping, Guid departGuid, Guid destinationGuid)
        {
            var depart = await addressRepository.GetAddress(departGuid);
            var destination = await addressRepository.GetAddress(destinationGuid);

            var shDepart = new ShippingAddress
            {
                Address = depart,
                AddressType = AddressType.Departure,
                Shipping = shipping,
                ShippingId = shipping.Id,
                AddressId = depart.Id
            };
            await shippingAddressRepository.Create(shDepart);
            
            var shDestination = new ShippingAddress
            {
                Address = destination,
                AddressType = AddressType.Arrival,
                Shipping = shipping,
                ShippingId = shipping.Id,
                AddressId = destination.Id
            };
            await shippingAddressRepository.Create(shDestination);
            
            await shippingAddressRepository.SaveAsync();
        }

        public async Task Update(Shipping shipping)
        {
            shippingRepository.Update(shipping);
            await shippingRepository.SaveAsync();
        }
    }
}
