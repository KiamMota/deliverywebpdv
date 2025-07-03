using Domain.Core.Entities.Interfaces;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Repositories.Base
{
    public class CrudBase<Entity, TId> : ICrudBase<Entity, TId> where Entity : class, IEntity<TId>
    {
        private readonly AppDbContext _context;

        public TId Create(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            _context.SaveChanges();
            return entity.Id; 
        }


        public bool DeleteById(TId id)
        {
            var result = _context.Set<Entity>().Remove(ReadById(id));
            if(result == null) return false;
            return true;
        }

        public IList<Entity> ReadAll()
        {
            return _context.Set<Entity>().ToList();
        }

        public Entity ReadById(TId id)
        {
            var result = _context.Set<Entity>().Entry(ReadById(id));
            if (result is null) return Entity;
            return Entity;
        }

        public bool UpdateById(Entity newEntity, TId id)
        {
            throw new NotImplementedException();
        }
    }
}
