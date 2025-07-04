using Domain.Core.Entities.Endereco;
using Infra.Data.Repositories.Interfaces;
using Infra.Data.DataModels;
using Infra.Data.Mappers;

namespace Infra.Data.Repositories
{
    public interface IEnderecoRepo
    {
        long Salvar(Endereco entity);
        Endereco? GetById(long id);
        bool PutById(Endereco entity, long id);
        bool DeleteById(long id);
        IList<Endereco> ReadAll();
    }

}
