using Domain.Core.Entities.Endereco;
using Infra.Data.Repositories.Interfaces;
using Infra.Data.DataModels;
using Infra.Data.Mappers;

namespace Infra.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
            private readonly ICrudBase<Endereco, DataEndereco> _crudBase;
            public EnderecoRepository(ICrudBase<Endereco, DataEndereco> crudBase)
            {
                _crudBase = crudBase;
            }

            public long Salvar(Endereco endereco)
            {
                return _crudBase.Create(endereco);
            }
            public Endereco? GetById(long id)
            {
                return _crudBase.ReadById(id);
            }
            public bool PutById(Endereco entity, long id)
            {
                return _crudBase.UpdateById(entity, id);
            }
            public bool DeleteById(long id)
            {
                return _crudBase.DeleteById(id);
            }
            public IList<Endereco> ReadAll()
            {
            return _crudBase.ReadAll();
            }

    }

}
