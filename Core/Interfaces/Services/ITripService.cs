namespace Hashdji.Software.Core.Interfaces.Services
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITripService
    {
        Task CreateTrip(Trip trip, Guid carrierId);

        Task AddShippings(Guid guid, List<Guid> shippingGuids);

        Task<IEnumerable<Trip>> GetTrips();
    }
}
