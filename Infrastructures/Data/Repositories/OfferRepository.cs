namespace Hashdji.Software.Infrastructure.Data.Repositories
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public class OfferRepository :  RepositoryBase<Offer>, IOfferRepository
    {

        public OfferRepository(RepositoryContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Offer>> GetOffers()
        {
            return await GetAll();
        }

        public async Task<IEnumerable<Offer>> GetOffersByCondition(Expression<Func<Offer, bool>> predicate)
        {
            return await Find(predicate);
        }

        public async Task<Offer> GetOffer(long id)
        {
            return await GetEntity(id);
        }

        public async Task<Offer> GetOffer(Guid guid)
        {
            return await GetEntity(guid);
        }

        public async Task CreateOffer(Offer offer)
        {
            await Create(offer);
            await SaveAsync();
        }

        public async Task UpdateOffer(Offer inDb, Offer updatedOffer)
        {
            inDb.Map(updatedOffer);
            Update(inDb);
            await SaveAsync();
        }

        public async Task DeleteOffer(Offer offer)
        {
            Delete(offer);
            await SaveAsync();
        }
    }
}
