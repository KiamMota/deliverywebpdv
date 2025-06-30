using Domain.Core.Entities;
using Domain.Core.Entities.Interfaces;

namespace Infra.Data.Repositories.Interfaces
{
    public interface ICrudBase<Entity> where Entity : class, IEntityBase
    {
        public long? Create(Entity entity);
        public Entity? ReadById(int id);
        public Entity? ReadByString(string str);
        public bool? DeleteByString(string str);
        public IList<Entity> ReadAll();
        public bool UpdateById(Entity newEntity, int id);
        public bool DeleteById(int id);
    }
}
