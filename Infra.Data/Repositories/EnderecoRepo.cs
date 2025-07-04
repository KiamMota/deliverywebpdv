using Domain.Core.Entities.Endereco;
using Infra.Data.DataModels;
using Infra.Data.Mappers;
using Infra.Data.Repositories.Base;

namespace Infra.Data.Repositories
{
    public class EnderecoRepo : IEnderecoRepo
    {
            private readonly ICrudBase<Endereco, EnderecoDb> _crudBase;
            public EnderecoRepo(ICrudBase<Endereco, EnderecoDb> crudBase)
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
