namespace Hashdji.Software.Infrastructure.Data.Repositories
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class ShippingAddressRepository : RepositoryBase<ShippingAddress>, IShippingAddressRepository
    {
        public ShippingAddressRepository(RepositoryContext context)
            :base(context)
        {

        }

        public async Task<ShippingAddress> GetShippingAddress(Guid guid)
        {
            return await GetEntity(guid); 
        }
    }
}
