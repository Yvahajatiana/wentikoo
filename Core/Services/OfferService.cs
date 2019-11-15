namespace Hashdji.Software.Core.Services
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using Hashdji.Software.Core.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class OfferService : IOfferService
    {
        private readonly IOfferRepository offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            this.offerRepository = offerRepository;
        }

        public async Task CreateOffer(Offer offer)
        {
            await CreateOffer(offer);
        }

        public async Task DeleteOffer(int id)
        {
            var toDelete = await offerRepository.GetOffer(id);
            
            if(toDelete == null)
            {
                //TODO: Use throw Exception instead of return;
                return;
            }

            await offerRepository.DeleteOffer(toDelete);
        }

        public async Task<IEnumerable<Offer>> GetOffersForAdmin()
        {
            return await offerRepository.GetOffers();
        }

        public async Task UpdateOffer(int id, Offer updatedOffer)
        {
            var inDb = await offerRepository.GetOffer(id);

            if(inDb == null)
            {
                //TODO: Use throw Exception instead of return;
                return;
            }

            await offerRepository.UpdateOffer(inDb, updatedOffer);
        }

        public async Task<IEnumerable<Offer>> GetOffersForUserAsync(string userId)
        {
            return await offerRepository.GetOffersByCondition(offer => offer.Seller == userId);
        }

        public async Task<Offer> GetOffersDetailsAsync(long id)
        {
            return await offerRepository.GetOffer(id);
        }

        public async Task<Offer> GetOffersDetailsAsync(Guid guid)
        {
            return await offerRepository.GetOffer(guid);
        }
    }
}
