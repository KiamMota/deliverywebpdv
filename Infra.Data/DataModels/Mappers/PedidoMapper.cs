using Domain.Core.Entities.Pedido;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Base;

namespace Infra.Data.Mappers
{
    public class PedidoMapper : IMapperBase<Pedido, PedidoDb>
    {

        public PedidoDb ToData(Pedido domain)
        {
            return new DataModels.PedidoDb
            {
                Id = domain.Id,
                ClienteId = domain.ClienteId,
                ProdutoId = domain.ProdutoId,
            };
        }

        public Pedido ToDomain(PedidoDb data)
        {
            throw new NotImplementedException();
        }
    }
}
