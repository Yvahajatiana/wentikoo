namespace Hashdji.Software.Core.Interfaces.Repositories
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAddressRepository : IRepository<Address>
    {
        Task<IEnumerable<Address>> GetAddresses();

        Task<Address> GetAddress(Guid guid);

        Task CreateAddress(Address address);

        Task UpdateAddress(Address inDb, Address updated);

        Task DeleteAddress(Address address);
    }
}
