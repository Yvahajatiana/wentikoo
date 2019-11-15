using Hashdji.Software.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hashdji.Software.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        Task<T> GetEntity(long id);

        Task<T> GetEntity(Guid guid);

        Task Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task SaveAsync();
    }
}
