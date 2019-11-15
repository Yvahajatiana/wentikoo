namespace Hashdji.Software.Core.Interfaces.Repositories
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IShippingAddressRepository : IRepository<ShippingAddress>
    {
        Task<ShippingAddress> GetShippingAddress(Guid guid);
    }
}
