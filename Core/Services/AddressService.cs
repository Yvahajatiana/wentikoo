namespace Hashdji.Software.Core.Services
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using Hashdji.Software.Core.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class AddressService : IAddressService
    {
        private readonly IAddressRepository addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public async Task Create(Address address)
        {
            await addressRepository.CreateAddress(address);
        }

        public async Task Delete(Guid guid)
        {
            var address = await addressRepository.GetAddress(guid);
            await addressRepository.DeleteAddress(address);
        }

        public async Task<Address> GetAddress(Guid guid)
        {
            return await addressRepository.GetAddress(guid);
        }

        public async Task<IEnumerable<Address>> GetAddressesAsync()
        {
            return await addressRepository.GetAddresses();
        }

        public async Task Update(Guid guid, Address address)
        {
            var inDb = await addressRepository.GetAddress(guid);
            await addressRepository.UpdateAddress(inDb, address);
        }
    }
}
