namespace Hashdji.Software.Infrastructure.Data.Repositories
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CarrierRepository : RepositoryBase<Carrier>, ICarrierRepository
    {
        public CarrierRepository(RepositoryContext context) 
            : base(context)
        {
        }
    }
}
