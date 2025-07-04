using Domain.Core.Entities.Cliente;
using Domain.Core.Entities.Endereco;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IClienteRepo
    {
        long    Salvar(Cliente entity);
        Cliente? GetById(long id);
        bool    PutById(Cliente entity, long id);
        bool    DeleteById(long id);
        IList<Cliente> ReadAll();
    }
}
