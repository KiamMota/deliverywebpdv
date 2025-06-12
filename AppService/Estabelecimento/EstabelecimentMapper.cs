using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;

namespace AppService.Estabelecimento
{
    public class EstabelecimentoMapper 
    {
        public static EstabelecimentoResponse? ToEstbResponse(Domain.Core.Entities.Estabelecimento estabelecimento)
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

        public static EstabelecimentoRequest? ToEstbRequest(Domain.Core.Entities.Estabelecimento request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            return new EstabelecimentoRequest
            {
                nome = request.nome,
                categorias = request.categorias,
                descricao = request.descricao,
                local = request.local
            };
        }

        public static Domain.Core.Entities.Estabelecimento? FromEstbResponse(EstabelecimentoResponse response)
        {
            if(response == null) throw new ArgumentNullException(nameof(response));
            return new Domain.Core.Entities.Estabelecimento
            {
                id = response.id,
                nome = response.nome,
                categorias = response.categorias,
                descricao = response.descricao,
                local = response.local
            };
        }

        public static Domain.Core.Entities.Estabelecimento? FromEstbRequest(EstabelecimentoRequest request)
        {
            if(request == null) throw new ArgumentNullException();
            return new Domain.Core.Entities.Estabelecimento {

                nome = request.nome,
                categorias = request.categorias,
                descricao = request.descricao,
                local = request.local
            };
        }

    }
}
