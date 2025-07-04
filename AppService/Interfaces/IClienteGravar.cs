
using Contracts.RequestModels;
using Contracts.ResponseModels;
using Domain.Core.Entities.Cliente;

namespace AppService.Interfaces
{
    public interface IClienteGravar
    {
        long Salvar(ClienteRequest entity);
        ClienteResponse GetById(long id);
        bool PutById(ClienteRequest entity, long id);
        bool DeleteById(long id);
        IList<ClienteResponse> GetAll();
    }
}
