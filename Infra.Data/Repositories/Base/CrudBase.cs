
using Domain.Core.Entities;

namespace Infra.Data.Repositories.Base
{
    public class CrudBase<Entity> : ICrudBase<Entity> where Entity : class, IEntity
    {
        private readonly AppDbContext _context;
        public CrudBase(AppDbContext _context)
        {
            this._context = _context;
        }
        public bool Create(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteById(int id)
        {
            var e = _context.Set<Entity>().Find(id);
            if (e == null) return false;
            _context.Set<Entity>().Remove(e);
            return _context.SaveChanges() > 0;
        }

        public IList<Entity> ReadAll()
        {
            var retorno = _context.Set<Entity>().ToList();
            return retorno;
        }
        public Entity ReadById(int id)
        {
            return _context.Set<Entity>().Find(id);
        }

        public bool UpdateById(Entity newEntity, int id)
        {
            var existsEntity = _context.Set<Entity>().Find(id);
            if (existsEntity == null) return false;
            _context.Entry(existsEntity).CurrentValues.SetValues(newEntity);
            return _context.SaveChanges() > 0;
        }
    }
}
