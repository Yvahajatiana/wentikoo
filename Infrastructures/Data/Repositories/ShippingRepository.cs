namespace Hashdji.Software.Infrastructure.Data.Repositories
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Factories;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class ShippingRepository : RepositoryBase<Shipping>, IShippingRepository
    {
        public ShippingRepository(RepositoryContext context)
            :base(context)
        {
        }

        public async Task CreateShipping(Shipping shipping)
        {
            await Create(shipping);
            await SaveAsync();
        }

        public async Task DeleteShipping(Shipping shipping)
        {
            Delete(shipping);
            await SaveAsync();
        }

        public async Task<Shipping> GetShipping(Guid guid)
        {
            return await GetEntity(guid);
        }

        public async Task<IEnumerable<Shipping>> GetShippings()
        {
            return await GetAll();
        }

        public async Task UpdateShipping(Shipping inDb, Shipping updated)
        {
            inDb.Map(updated);
            Update(inDb);
            await SaveAsync();
        }

        public async Task UpdateShipping(Shipping shipping)
        {
            Update(shipping);
            await SaveAsync();
        }
    }
}
