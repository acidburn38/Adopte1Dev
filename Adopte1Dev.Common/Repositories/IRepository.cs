using System.Collections.Generic;

namespace Adopte1Dev.Common.Repositories
{
    public interface IRepository<TEntity, TId> : IGetRepository<TEntity, TId>
    {

        TId Insert(TEntity entity);
        void Delete(TId id);
        void Update(TId id, TEntity entity);
    }
}