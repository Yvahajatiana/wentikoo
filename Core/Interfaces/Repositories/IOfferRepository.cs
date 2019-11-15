namespace Hashdji.Software.Core.Interfaces.Repositories
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public interface IOfferRepository
    {
        Task<IEnumerable<Offer>> GetOffers();

        Task<IEnumerable<Offer>> GetOffersByCondition(Expression<Func<Offer, bool>> predicate);

        Task<Offer> GetOffer(long id);

        Task<Offer> GetOffer(Guid guid);

        Task CreateOffer(Offer offer);

        Task UpdateOffer(Offer inDb, Offer updatedOffer);

        Task DeleteOffer(Offer offer);
    }
}
