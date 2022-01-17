using System.Collections.Generic;

namespace Adopte1Dev.Common.Repositories
{
    public interface IRepository<TEntity, TId>
    {

        TId Insert(TEntity entity);
        TEntity Get(TId id);
        IEnumerable<TEntity> Get();
        void Delete(TId id);
        void Update(TId id, TEntity entity);
    }
}