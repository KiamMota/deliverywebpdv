using Domain.Core.Entities;
using Domain.Core.Entities.Interfaces;

namespace Infra.Data.Repositories.Interfaces
{
    public interface ICrudBase<Entity, TName> where Entity : class, IAggregate<TName>
    {
        public void Create(Entity entity);
        public Entity? ReadById(long id);
        public Entity? ReadByString(TName name);
        public bool? DeleteByString(TName str);
        public IList<Entity> ReadAll();
        public bool UpdateById(Entity newEntity, long id);
        public bool DeleteById(long Id);
    }
}
