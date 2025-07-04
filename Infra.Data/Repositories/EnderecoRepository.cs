using Domain.Core.Entities.Endereco;
using Infra.Data.Repositories.Interfaces;
using Infra.Data.DataModels;
using Infra.Data.Mappers;

namespace Infra.Data.Repositories
{
    public class EnderecoRepository
    {
        private readonly ICrudBase<DataEndereco, EnderecoMapper> _crudBase;
        public EnderecoRepository(ICrudBase<DataEndereco, EnderecoMapper> _crudEndereco)
        {
            _crudBase = _crudEndereco;
        }

        public long Salvar(Endereco entity)
        {
            return _crudBase.Create(entity);
        }

    }
}
