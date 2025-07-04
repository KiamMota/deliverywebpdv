using Domain.Core.Entities.Produto;
using Domain.Core.Kel;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Base;

namespace Infra.Data.Mappers
{
    public class ProdutoMapper : IMapperBase<Domain.Core.Entities.Produto.Produto, ProdutoDb>
    {

        public ProdutoDb ToData(Domain.Core.Entities.Produto.Produto domain)
        {
            return new DataModels.ProdutoDb
            {
                Nome = domain.Nome.nome,
                Preco = domain.Preco.preco,
                Disponivel = domain.Disponivel.Disponibilidade
            };
        }

        public Domain.Core.Entities.Produto.Produto ToDomain(ProdutoDb data)
        {
            throw new NotImplementedException();
        }
    }
}
