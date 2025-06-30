
using Domain.Core.Entities;
using Domain.Core.Entities.Interfaces;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Repositories.Base
{
    public class CrudBase<Entity> : ICrudBase<Entity> where Entity : class, IEntityBase
    {
        private readonly AppDbContext _context;
        public CrudBase(AppDbContext _context)
        {
            this._context = _context;
        }
        public long? Create(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public bool DeleteById(long id)
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

        public bool? DeleteByString(string str)
        {
            var set = _context.Set<Entity>();
            var search = set.FirstOrDefault(e => e.Name == str);
            if(search == null) return false;
            set.Remove(search);
            _context.SaveChanges();
            return true;
        }

        public Entity? ReadById(long id)
        {
            return _context.Set<Entity>().Find(id);
        }

        public Entity? ReadByString(string str)
        {
            var GetEntity = _context.Set<Entity>().Find();
            return GetEntity != null ? GetEntity : null;
        }

        public bool UpdateById(Entity newEntity, long id)
        {
            var existsEntity = _context.Set<Entity>().Find(id);
            if (existsEntity == null) return false;
            _context.Entry(existsEntity).CurrentValues.SetValues(newEntity);
            return _context.SaveChanges() > 0;
        }

    }
}
