namespace Infra.Data.Mappers
{
    public class ProdutoMapper
    {
        public static DataModels.DataProduto ProdutoData(Domain.Core.Entities.Produto.Produto produto)
        {
            return new DataModels.DataProduto
            {
                Nome = produto.Nome.nome,
                Preco = produto.Preco.preco,
                Disponivel = produto.Disponivel.Disponibilidade
            };
        }


    }
}
