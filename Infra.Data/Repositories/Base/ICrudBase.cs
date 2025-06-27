using Domain.Core.Entities.Base;

namespace Infra.Data.Repositories.Base
{
    public interface ICrudBase<Entity> where Entity : class, IEntity
    {
        public bool Create(Entity entity);
        public Entity ReadById(int id);
        public IList<Entity> ReadAll();
        public bool UpdateById(Entity newEntity, int id);
        public bool DeleteById(int id);
    }
}
