using Domain.Core.Kel;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Base;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Repositories
{
    public class ClienteRepo : IClienteRepo
    {
        private readonly ICrudBase<Domain.Core.Entities.Cliente.Cliente, ClienteDb> _crudBase;
        public ClienteRepo(ICrudBase<Domain.Core.Entities.Cliente.Cliente, ClienteDb> crudBase)
        {
            _crudBase = crudBase ?? throw new ArgumentNullException(nameof(crudBase), "O repositório não pode ser nulo.");
        }

        public bool DeleteById(long id)
        {
            return _crudBase.DeleteById(id);
        }

        public Domain.Core.Entities.Cliente.Cliente? GetById(long id)
        {
            return _crudBase.ReadById(id) ?? throw new Exception($"Cliente com ID {id} não encontrado.");
        }

        public bool PutById(Domain.Core.Entities.Cliente.Cliente entity, long id)
        {
            if (entity == null) throw new Exception("A entidade não pode ser nula.");
            if (id <= 0) throw new Exception("O ID deve ser maior que zero.");
            return _crudBase.UpdateById(entity, id);
        }

        public IList<Domain.Core.Entities.Cliente.Cliente> ReadAll()
        {
            var clientes = _crudBase.ReadAll();
            if (clientes == null || !clientes.Any())
            {
                throw new Exception("Nenhum cliente encontrado.");
            }
            return clientes;
        }

        public long Salvar(Domain.Core.Entities.Cliente.Cliente entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), "A entidade não pode ser nula.");
            return _crudBase.Create(entity);
        }
    }
}
