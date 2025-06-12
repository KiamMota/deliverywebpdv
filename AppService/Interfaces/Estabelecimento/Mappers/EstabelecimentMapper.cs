using AppService.Mappers.Interfaces;
using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;
using Domain.Core.Entities;


namespace AppService.Interfaces.EstabelecimentoMappers
{

    public class EstabelecimentoMapper : IEstabelecimentoMapper
    {
        public EstabelecimentoResponse? ToEstbResponse(Estabelecimento estabelecimento)
        {
            if (estabelecimento == null) throw new ArgumentNullException($"o valor de {nameof(estabelecimento)} é nulo!");
            return new EstabelecimentoResponse
            {
                id = estabelecimento.id,
                nome = estabelecimento.nome,
                categorias = estabelecimento.categorias,
                descricao = estabelecimento.descricao,
                local = estabelecimento.local
            };
        }

        public EstabeleimentoRequest? ToEstRequest(Estabelecimento request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            return new EstabeleimentoRequest
            {
                nome = request.nome,
                categorias = request.categorias,
                descricao = request.descricao,
                local = request.local
            };
        }
    }
}
