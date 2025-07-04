using Domain.Core.Entities;
using Domain.Core.Entities.Endereco;
using Domain.Core.Entities.Interfaces;

namespace Infra.Data.Repositories.Interfaces
{
    public interface ICrudBase<TEntity, TData>
    {
        long Create(TEntity entity);
        TEntity?     ReadById(long id);
        IList<TEntity> ReadAll();
        bool UpdateById(TEntity newEntity, long id);
        bool DeleteById(long id);
    }
}
