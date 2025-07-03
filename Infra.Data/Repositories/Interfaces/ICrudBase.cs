using Domain.Core.Entities;
using Domain.Core.Entities.Interfaces;

namespace Infra.Data.Repositories.Interfaces
{
    public interface ICrudBase<TEntity, TId> where TEntity : IEntity<TId>
    {
        TId Create(TEntity entity);
        TEntity?     ReadById(TId id);
        IList<TEntity> ReadAll();
        bool UpdateById(TEntity newEntity, TId id);
        bool DeleteById(TId id);
    }
}
