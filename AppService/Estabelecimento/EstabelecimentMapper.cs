using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;

namespace AppService.Estabelecimento
{
    public class EstabelecimentoMapper 
    {
        public static EstabelecimentoResponse? ToEstbResponse(Domain.Core.Entities.Estabelecimento estabelecimento)
        {
            if (estabelecimento == null) throw new ArgumentNullException($"o pedidoValor de {nameof(estabelecimento)} é nulo!");
            return new EstabelecimentoResponse
            {
                id = estabelecimento.estabId,
                nome = estabelecimento.estabNome,
                categorias = estabelecimento.estabCategorias,
                descricao = estabelecimento.estabDescricao,
                local = estabelecimento.estabLocal
            };
        }

        public static EstabelecimentoRequest? ToEstbRequest(Domain.Core.Entities.Estabelecimento request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            return new EstabelecimentoRequest
            {
                nome = request.estabNome,
                categorias = request.estabCategorias,
                descricao = request.estabDescricao,
                local = request.estabLocal
            };
        }

        public static Domain.Core.Entities.Estabelecimento? FromEstbResponse(EstabelecimentoResponse response)
        {
            if(response == null) throw new ArgumentNullException(nameof(response));
            return new Domain.Core.Entities.Estabelecimento
            {
                estabId = response.id,
                estabNome = response.nome,
                estabCategorias = response.categorias,
                estabDescricao = response.descricao,
                estabLocal = response.local
            };
        }

        public static Domain.Core.Entities.Estabelecimento? FromEstbRequest(EstabelecimentoRequest request)
        {
            if(request == null) throw new ArgumentNullException();
            return new Domain.Core.Entities.Estabelecimento {

                estabNome = request.nome,
                estabCategorias = request.categorias,
                estabDescricao = request.descricao,
                estabLocal = request.local
            };
        }

    }
}
