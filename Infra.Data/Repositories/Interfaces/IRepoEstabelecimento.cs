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
        /* deletes */
        bool            DeleteEstabelecimentoById(int id);
        bool            DeleteEstabelecimentoByNome(string nome);
    }
}
