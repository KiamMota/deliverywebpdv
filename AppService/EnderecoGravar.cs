using AppService.Interfaces;
using AppService.Mappers;
using Contracts.RequestModels;
using Contracts.ResponseModels;
using Infra.Data.Repositories;

namespace AppService
{
    public class EnderecoGravar : IEnderecoGravar
    {
        private readonly IEnderecoRepository _estabelecimentorepo;
        public EnderecoGravar(IEnderecoRepository _estabelecimento)
        {
            _estabelecimentorepo = _estabelecimento;
        }
        public bool DeleteById(long id)
        {
            return _estabelecimentorepo.DeleteById(id);
        }

        public IList<EnderecoResponse> GetAll()
        {
            var endereco = _estabelecimentorepo.ReadAll();
            if (endereco == null || !endereco.Any())
            {
                return new List<EnderecoResponse>();
            }
            return null;
        }

        public EnderecoResponse GetById(long id)
        {
            var endereco = _estabelecimentorepo.GetById(id);
            return EnderecoRQ.DomainToResponse(endereco);
        }

        public bool PutById(EnderecoRequest entity, long id)
        {
            return _estabelecimentorepo.PutById(EnderecoRQ.RequestToDomain(entity), id);
        }

        public long Salvar(EnderecoRequest entity)
        {
            var endereco = EnderecoRQ.RequestToDomain(entity);
            return _estabelecimentorepo.    Salvar(endereco);
        }
    }
}
