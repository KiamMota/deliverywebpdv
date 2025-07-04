using Domain.Core.Entities.Interfaces;
using Infra.Data.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Infra.Data.Repositories.Base
{
    public class CrudBase<TEntity, TData> : ICrudBase<TEntity, TData> where TData : class, new() where TEntity : class, IEntity<long>
    {
        private readonly AppDbContext _context;
        private readonly IMapperBase<TEntity, TData> _mapper;   
        public CrudBase(IMapperBase<TEntity, TData> mapper, AppDbContext _context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._context = _context ?? throw new ArgumentNullException(nameof(_context), "O contexto não pode ser nulo.");
        }
        public long Create(TEntity entity)
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

        public IList<TEntity> ReadAll()
        {
            /* aqui ele pega todos os dados do banco e converte para a entidade de dominio */
            var dataEntities = _context.Set<TData>().ToList();
            return dataEntities.Select(_mapper.ToDomain).ToList() ?? new List<TEntity>();
        }
        public TEntity? ReadById(long id)
        {
            /* a varProp.. recebe o valor da chaveprimaria da entidade com base na entidade, e retorna a primeira ou a padrão*/
            var keyProperty = _context.Model.FindEntityType(typeof(TEntity))?
                .FindPrimaryKey()?.Properties.FirstOrDefault();

            if (keyProperty == null) throw new Exception("A chave primária não foi encontrada para a entidade.");

            var parameter = Expression.Parameter(typeof(TEntity), "e");
            var property = Expression.Property(parameter, keyProperty.Name);
            var constant = Expression.Constant(id);
            var equals = Expression.Equal(property, constant);
            var lambda = Expression.Lambda<Func<TEntity, bool>>(equals, parameter);

            return _context.Set<TEntity>().FirstOrDefault(lambda);
        }
        public bool UpdateById(TEntity newEntity, long id)
        {
            /*obtem a chave primaria da entidade*/
            var keyProperty = _context.Model.FindEntityType(typeof(TData))?
                .FindPrimaryKey()?.Properties.FirstOrDefault();

            if (keyProperty == null)
                throw new Exception("A chave primária não foi encontrada para a entidade.");

            /* vê se a entidade existe com base no id*/
            var existingData = _context.Set<TData>().Find(id);
            if (existingData == null)
                return false; // Retorna falso se a entidade não for encontrada

            /* aqui ele passa os valores do newentity para o existing entity*/

            var updateToData = _mapper.ToData(newEntity) ?? throw new ArgumentNullException(nameof(newEntity), "A nova entidade não pode ser nula.");
            _context.Entry(existingData).CurrentValues.SetValues(updateToData);

            return _context.SaveChanges() > 0;
        }

    }
}
