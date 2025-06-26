using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;

namespace AppService.Mappers
{
    public sealed class EstabelecimentoMapper
    {
        public static EstabelecimentoResponse? ToEstbResponse(Domain.Core.Entities.Estabelecimento estabelecimento)
        {
            if (estabelecimento == null) throw new ArgumentNullException($"o pedidoValor de {nameof(estabelecimento)} é nulo!");
            return new EstabelecimentoResponse
            {
                id = estabelecimento.EstabelecimentoId,
                nome = estabelecimento.EstabelecimentoNome,
                categorias = estabelecimento.EstabelecimentoCategorias,
                descricao = estabelecimento.EstabelecimentoDescricao,
                local = estabelecimento.EstabelecimentoLocal
            };
        }

        public static EstabelecimentoRequest? ToEstbRequest(Domain.Core.Entities.Estabelecimento request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            return new EstabelecimentoRequest
            {
                nome = request.EstabelecimentoNome,
                categorias = request.EstabelecimentoCategorias,
                descricao = request.EstabelecimentoDescricao,
                local = request.EstabelecimentoLocal
            };
        }

        public static Domain.Core.Entities.Estabelecimento? FromEstbResponse(EstabelecimentoResponse response)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new Domain.Core.Entities.Estabelecimento
            {
                EstabelecimentoId = response.id,
                EstabelecimentoNome = response.nome,
                EstabelecimentoCategorias = response.categorias,
                EstabelecimentoDescricao = response.descricao,
                EstabelecimentoLocal = response.local
            };
        }

        public static Domain.Core.Entities.Estabelecimento? FromEstbRequest(EstabelecimentoRequest request)
        {
            if (request == null) throw new ArgumentNullException();
            return new Domain.Core.Entities.Estabelecimento
            {

                EstabelecimentoNome = request.nome,
                EstabelecimentoCategorias = request.categorias,
                EstabelecimentoDescricao = request.descricao,
                EstabelecimentoLocal = request.local
            };
        }
    }
}
