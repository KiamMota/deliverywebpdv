using Domain.Core.Entities;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IRepoEstabelecimento
    {
        int             SaveEstabelecimento(Estabelecimento estabelecimento);
        /* gets */
        Estabelecimento? GetEstabelecimentoById(int id);
        Estabelecimento? GetEstabelecimentoByNome(string nome);
        Estabelecimento? GetEstabelecimentoByCategorias(string categorias);
        /* puts */
        bool PutEstabelecimentoById(Estabelecimento estabelecimentoNovo, int id);
        /* deletes */
        bool            DeleteEstabelecimentoById(int id);
        bool            DeleteEstabelecimentoByNome(string nome);
    }
}
