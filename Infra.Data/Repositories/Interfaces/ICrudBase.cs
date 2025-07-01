using Domain.Core.Entities;
using Domain.Core.Entities.Interfaces;

namespace Infra.Data.Repositories.Interfaces
{
    public interface ICrudBase<Entity> where Entity : class
    {
        public long? Create(Entity entity);
        public Entity? ReadById(long id);
        public Entity? ReadByString(string str);
        public bool? DeleteByString(string str);
        public IList<Entity> ReadAll();
        public bool UpdateById(Entity newEntity, long id);
        public bool DeleteById(long id);
    }
}
