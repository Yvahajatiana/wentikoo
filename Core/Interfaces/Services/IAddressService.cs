namespace Hashdji.Software.Core.Interfaces.Services
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAddressService
    {
        Task<IEnumerable<Address>> GetAddressesAsync();

        Task<Address> GetAddress(Guid guid);

        Task Create(Address address);

        Task Update(Guid guid, Address address);

        Task Delete(Guid guid);
    }
}
