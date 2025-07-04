using Domain.Core.Entities.Interfaces;
using System.Linq.Expressions;

namespace Infra.Data.Repositories.Base
{
    public class CrudBase<TDomain, TData> : ICrudBase<TDomain, TData> 
        where TData : class, new() 
        where TDomain : class, IEntity<long>
    {
        private readonly AppDbContext _context;
        private readonly IMapperBase<TDomain, TData> _mapper;   
        public CrudBase(IMapperBase<TDomain, TData> mapper, AppDbContext _context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._context = _context ?? throw new ArgumentNullException(nameof(_context), "O contexto não pode ser nulo.");
        }
        public long Create(TDomain entity)
        {
            TData dataEntity = _mapper.ToData(entity) ?? throw new ArgumentNullException(nameof(entity), "A entidade não pode ser nula.");
            _context.Set<TData>().Add(dataEntity);
            _context.SaveChanges();
            var entry = _context.Entry(dataEntity);
            var idProperty = entry.Metadata.FindPrimaryKey()?.Properties.FirstOrDefault();

            if (idProperty == null)
                throw new InvalidOperationException("A chave primária não foi encontrada para a entidade.");

            var idValue = entry.Property(idProperty.Name).CurrentValue;

            if (idValue == null || !long.TryParse(idValue.ToString(), out var id))
                throw new InvalidOperationException("Não foi possível converter o valor da chave primária para long.");

            return id;
        }
        public bool DeleteById(long id)
        {
            var data = _context.Set<TData>().Find(id);
            if (data == null) return false;
            _context.Set<TData>().Remove(data);
            return _context.SaveChanges() > 0;
        }

        public IList<TDomain> ReadAll()
        {
            var dataEntities = _context.Set<TData>().ToList();
            return dataEntities.Select(_mapper.ToDomain).ToList() ?? new List<TDomain>();
        }
        public TDomain? ReadById(long id)
        {
            var keyProperty = _context.Model.FindEntityType(typeof(TDomain))?
                .FindPrimaryKey()?.Properties.FirstOrDefault();

            if (keyProperty == null) throw new Exception("A chave primária não foi encontrada para a entidade.");

            var parameter = Expression.Parameter(typeof(TDomain), "e");
            var property = Expression.Property(parameter, keyProperty.Name);
            var constant = Expression.Constant(id);
            var equals = Expression.Equal(property, constant);
            var lambda = Expression.Lambda<Func<TDomain, bool>>(equals, parameter);

            return _context.Set<TDomain>().FirstOrDefault(lambda);
        }
        public bool UpdateById(TDomain newEntity, long id)
        {
            var keyProperty = _context.Model.FindEntityType(typeof(TData))?
                .FindPrimaryKey()?.Properties.FirstOrDefault();

            if (keyProperty == null)
                throw new Exception("A chave primária não foi encontrada para a entidade.");

            var existingData = _context.Set<TData>().Find(id);
            if (existingData == null)
                return false;
            var updateToData = _mapper.ToData(newEntity) ?? throw new ArgumentNullException(nameof(newEntity), "A nova entidade não pode ser nula.");
            _context.Entry(existingData).CurrentValues.SetValues(updateToData);

            return _context.SaveChanges() > 0;
        }

    }
}
