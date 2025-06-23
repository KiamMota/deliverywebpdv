using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;

namespace AppService.Interfaces.Estabelecimento
{
    public interface IProcessEstabelecimento
    {
        int SalvarEstabelecimento(EstabelecimentoRequest estabelecimento);
        EstabelecimentoResponse? GetEstabelecimentoById(int id);
        EstabelecimentoResponse? GetEstabelecimentoByNome(string nome);
        bool PutEstabelecimentoById(EstabelecimentoRequest estabelecimentoNovo, int id);
        bool DeleteEstabelecimentoById(int id);
        bool DeleteEstabelecimentoByNome(string nome);

    }
}
