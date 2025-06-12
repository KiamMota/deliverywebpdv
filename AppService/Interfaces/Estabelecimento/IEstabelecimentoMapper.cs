using Contracts.ContractsEstabelecimento.Response;
using Contracts.ContractsEstabelecimento.Request;
using Domain.Core.Entities;

namespace AppService.Mappers.Interfaces
{
    public interface IEstabelecimentoMapper
    {
        EstabelecimentoResponse? ToEstbResponse(Estabelecimento estabelecimento);
        EstabeleimentoRequest? ToEstRequest(Estabelecimento request);
    }
}
