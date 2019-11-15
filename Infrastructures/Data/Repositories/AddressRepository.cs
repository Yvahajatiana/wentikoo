namespace Hashdji.Software.Infrastructure.Data.Repositories
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Factories;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(RepositoryContext context)
            :base(context)
        {

        }

        public async Task CreateAddress(Address address)
        {
            await Create(address);
            await SaveAsync();
        }

        public async Task DeleteAddress(Address address)
        {
            Delete(address);
            await SaveAsync();
        }

        public async Task<Address> GetAddress(Guid guid)
        {
            return await GetEntity(guid);
        }

        public async Task<IEnumerable<Address>> GetAddresses()
        {
            return await GetAll();
        }

        public async Task UpdateAddress(Address inDb, Address updated)
        {
            inDb.Map(updated);
            Update(inDb);
            await SaveAsync();
        }
    }
}
