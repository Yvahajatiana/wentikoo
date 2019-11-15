namespace Hashdji.Software.Core.Interfaces.Repositories
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IShippingRepository : IRepository<Shipping>
    {
        Task<IEnumerable<Shipping>> GetShippings();

        Task<Shipping> GetShipping(Guid guid);

        Task CreateShipping(Shipping shipping);

        Task UpdateShipping(Shipping inDb, Shipping updated);

        Task UpdateShipping(Shipping shipping);

        Task DeleteShipping(Shipping shipping);
    }
}
