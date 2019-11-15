namespace Hashdji.Software.Core.Services
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Exceptions;
    using Hashdji.Software.Core.Helpers;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using Hashdji.Software.Core.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public class TripService : ITripService
    {
        private readonly IShippingRepository shippingRepository;
        private readonly ITripRepository tripRepository;
        private readonly ICarrierRepository carrierRepository;

        public TripService(
            IShippingRepository shippingRepository, 
            ITripRepository tripRepository, 
            ICarrierRepository carrierRepository)
        {
            this.shippingRepository = shippingRepository;
            this.tripRepository = tripRepository;
            this.carrierRepository = carrierRepository;
        }

        public async Task AddShippings(Guid guid, List<Guid> shippingGuids)
        {
            Expression<Func<Shipping, bool>> predicate = PredicateBuilder.True<Shipping>();

            shippingGuids.ForEach(x =>
            {
                predicate.Or(shipping => shipping.UniqueId.Equals(x));
            });
            var shippings = await shippingRepository.Find(predicate);

            var trip = await tripRepository.GetEntity(guid);
            if(trip == null)
            {
                throw new NotFoundException();
            }

            trip.Shippings = shippings.ToList();
            tripRepository.Update(trip);
            await tripRepository.SaveAsync();
        }

        public async Task CreateTrip(Trip trip, Guid carrierId)
        {
            var carrier = await carrierRepository.GetEntity(carrierId);
            if(carrier != null)
            {
                trip.Carrier = carrier;
                trip.CarrierId = carrier.Id;
            }

            await tripRepository.Create(trip);
            await tripRepository.SaveAsync();
        }

        public async Task<IEnumerable<Trip>> GetTrips()
        {
            return await tripRepository.GetAll();
        }
    }
}
