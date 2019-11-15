namespace Hashdji.Software.Infrastructure.Data.Repositories
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbSet<T> entities;
        private readonly RepositoryContext context;

        public RepositoryBase(RepositoryContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await entities.Where(predicate).ToListAsync();
        }

        public async Task<T> GetEntity(long id)
        {
            return await entities.FindAsync(id);
        }

        public async Task<T> GetEntity(Guid guid)
        {
            return await entities.SingleOrDefaultAsync(entity => entity.UniqueId.Equals(guid));
        }

        public async Task Create(T entity)
        {
            entity.UniqueId = Guid.NewGuid();
            await entities.AddAsync(entity);
        }

        public void Update(T entity)
        {
            entities.Update(entity); 
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
