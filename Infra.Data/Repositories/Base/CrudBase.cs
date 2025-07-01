using Domain.Core.Entities.Interfaces;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infra.Data.Repositories.Base
{
    public class CrudBase<Entity, TId, TName> : ICrudBase<Entity, TId, TName> where Entity : class, IAggregate<TId, TName>
    {
        private readonly AppDbContext _context;
        public CrudBase(AppDbContext _context)
        {
            this._context = _context;
        }
        public TId? Create(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public IList<Entity> ReadAll()
        {
            var retorno = _context.Set<Entity>().ToList();
            return retorno;
        }

        public bool? DeleteByString(TName str)
        {
            var set = _context.Set<Entity>();
            var search = set.FirstOrDefault(e => e.Name.Equals(str));
            if(search == null) return false;
            set.Remove(search);
            _context.SaveChanges();
            return true;
        }

        public Entity? ReadById(TId id)
        {
            return _context.Set<Entity>().Find(id);
        }

        public Entity? ReadByString(TName str)
        {
            var GetEntity = _context.Set<Entity>().Find(str);
            return GetEntity != null ? GetEntity : null;
        }

        public bool UpdateById(Entity newEntity, TId id)
        {
            var existsEntity = _context.Set<Entity>().Find(id);
            if (existsEntity == null) return false;
            _context.Entry(existsEntity).CurrentValues.SetValues(newEntity);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteById(TId Id)
        {
            throw new NotImplementedException();
        }
    }
}
