using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;

namespace AppService.Interfaces.Estabelecimento
{
    public interface IProcessEstabelecimento
    {
        Task<int> SalvarEstabelecimento(EstabelecimentoRequest estabelecimento);
        Task<EstabelecimentoResponse>? GetEstabelecimentoById(int id);
        Task<EstabelecimentoResponse>? GetEstabelecimentoByNome(string nome);
        Task<EstabelecimentoResponse>? GetEstabelecimentoByCategoria(string categorias);
        Task<bool> DeleteEstabelecimentoById(int id);
        Task<bool> DeleteEstabelecimentoByNome(string nome);

    }
}
