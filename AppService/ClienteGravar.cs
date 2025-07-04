using AppService.Mappers;
using Contracts.RequestModels;
using Contracts.ResponseModels;
using Infra.Data.Repositories.Interfaces;

namespace AppService
{
    public class ClienteGravar
    {
        private readonly IClienteRepo _clienteRepo;
        public ClienteGravar(IClienteRepo clienteRepo)
        {
            _clienteRepo = clienteRepo;
        }

        public bool DeleteById(long id)
        {
            return _clienteRepo.DeleteById(id);
        }
        public IList<ClienteResponse> GetAll()
        {
            var clientes = _clienteRepo.ReadAll();
            if (clientes == null || !clientes.Any())
            {
                return new List<ClienteResponse>();
            }
            return clientes.Select(c => ClienteAppMap.DomainToResponse(c)).ToList();
        }
        public ClienteResponse GetById(long id)
        {
            var cliente = _clienteRepo.GetById(id);
            return ClienteAppMap.DomainToResponse(cliente);
        }
        public bool PutById(ClienteRequest entity, long id)
        {
            return _clienteRepo.PutById(ClienteAppMap.RequestToDomain(entity), id);
        }
        public long Salvar(ClienteRequest entity)
        {
            var cliente = ClienteAppMap.RequestToDomain(entity);
            return _clienteRepo.Salvar(cliente);

        }
    }
}
