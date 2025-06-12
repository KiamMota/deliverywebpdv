using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;

namespace AppService.Interfaces.Estabelecimento
{
    public interface IProcessEstabelecimento
    {
        int SalvarEstabelecimento(Contracts.ContractsEstabelecimento.Request.EstabelecimentoRequest estabelecimento);
        EstabelecimentoResponse? GetEstabelecimentoById(int id);
        EstabelecimentoResponse? GetEstabelecimentoByNome(string nome);
        EstabelecimentoResponse? GetEstabelecimentoByCategoria(string categorias);
        bool DeleteEstabelecimentoById(int id);
        bool DeleteEstabelecimentoByNome(string nome);

    }
}
