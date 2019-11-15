namespace Hashdji.Software.Core.Interfaces.Services
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IShippingService
    {
        Task<Shipping> GetShipping(Guid guid);

        Task<IEnumerable<Shipping>> GetShippingsAsync();

        Task Create(Shipping shipping);

        Task Update(Shipping shipping);

        Task Delete(Guid guid);

        Task<Shipping> StartShipping(Guid guid, Shipping data);

        Task<Shipping> DeliveryShipping(Guid guid);

        Task AddAddresses(Shipping shipping, Guid departGuid, Guid destinationGuid);
    }
}
