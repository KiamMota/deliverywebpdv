using Contracts.VModels.ContractsEstabelecimento.Request;
using Contracts.VModels.ContractsEstabelecimento.Response;

namespace AppService.Mappers
{
    public sealed class EstabelecimentoMapper
    {
        public static EstabelecimentoResponse? ToEstbResponse(Domain.Core.Entities.Estabelecimento estabelecimento)
        {
            if (estabelecimento == null) throw new ArgumentNullException($"o pedidoValor de {nameof(estabelecimento)} é nulo!");
            return new EstabelecimentoResponse
            {
                id = estabelecimento.Id,
                nome = estabelecimento.Name,
                categorias = estabelecimento.Categorias,
                descricao = estabelecimento.Description,
                local = estabelecimento.Local
            };
        }

        public static EstabelecimentoRequest? ToEstbRequest(Domain.Core.Entities.Estabelecimento request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            return new EstabelecimentoRequest
            {
                nome = request.Name,
                categorias = request.Categorias,
                descricao = request.Description,
                local = request.Local
            };
        }

        public static Domain.Core.Entities.Estabelecimento? FromEstbResponse(EstabelecimentoResponse response)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new Domain.Core.Entities.Estabelecimento
            {
                Id = response.id,
                Name = response.nome,
                Categorias = response.categorias,
                Description = response.descricao,
                Local = response.local
            };
        }

        public static Domain.Core.Entities.Estabelecimento? FromEstbRequest(EstabelecimentoRequest request)
        {
            if (request == null) throw new ArgumentNullException();
            return new Domain.Core.Entities.Estabelecimento
            {

                Name = request.nome,
                Categorias = request.categorias,
                Description = request.descricao,
                Local = request.local
            };
        }
    }
}
