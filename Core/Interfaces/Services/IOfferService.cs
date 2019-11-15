namespace Hashdji.Software.Core.Interfaces.Services
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IOfferService
    {
        Task<IEnumerable<Offer>> GetOffersForAdmin();

        Task CreateOffer(Offer offer);

        Task UpdateOffer(int id, Offer updatedOffer);

        Task DeleteOffer(int id);

        Task<IEnumerable<Offer>> GetOffersForUserAsync(string userId);

        Task<Offer> GetOffersDetailsAsync(long id);

        Task<Offer> GetOffersDetailsAsync(Guid guid);
    }
}
