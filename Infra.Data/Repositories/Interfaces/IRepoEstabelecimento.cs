using Domain.Core.Entities;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IRepoEstabelecimento
    {
        Task<int>             SaveEstabelecimento(Estabelecimento estabelecimento);
        /* gets */
        Task<Estabelecimento>? GetEstabelecimentoById(int id);
        Task<Estabelecimento>? GetEstabelecimentoByNome(string nome);
        Task<Estabelecimento>? GetEstabelecimentoByCategorias(string categorias);
        /* deletes */
        Task<bool>            DeleteEstabelecimentoById(int id);
        Task<bool>            DeleteEstabelecimentoByNome(string nome);
    }
}
