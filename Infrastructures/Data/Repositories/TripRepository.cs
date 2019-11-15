namespace Hashdji.Software.Infrastructure.Data.Repositories
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TripRepository : RepositoryBase<Trip>, ITripRepository
    {
        public TripRepository(RepositoryContext context) 
            : base(context)
        {
        }
    }
}
