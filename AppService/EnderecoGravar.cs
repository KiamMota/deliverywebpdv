using AppService.Interfaces;
using AppService.Mappers;
using Contracts.RequestModels;
using Contracts.ResponseModels;
using Infra.Data.Repositories.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace AppService
{
    public class EnderecoGravar : IEnderecoGravar
    {
        private readonly ICrudBase<EnderecoResponse> _crudBase;
        public EnderecoGravar(ICrudBase<EnderecoResponse> crudBase)
        {
            _crudBase = crudBase;
        }
        public bool DeleteById(long id)
        {
            return _crudBase.DeleteById(id);
        }

        public IList<EnderecoResponse> GetAll()
        {
            return _crudBase.ReadAll();
        }

        public EnderecoResponse GetById(long id)
        {
            return _crudBase.ReadById(id) ?? throw new KeyNotFoundException($"Endereço com ID {id} não encontrado.");
        }

        public bool PutById(EnderecoRequest entity, long id)
        {
            return _crudBase.UpdateById(EnderecoRQ.RqToRp(entity), id);
        }

        public long Salvar(EnderecoRequest entity)
        {
            var endereco = EnderecoRQ.RequestToDomain(entity);
            return _crudBase.Create(endereco);
        }
    }
}
