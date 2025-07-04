namespace Infra.Data.Mappers
{
    public class PedidoMapper
    {
        public static DataModels.DataPedido PedidoData(Domain.Core.Entities.Pedido.Pedido pedido)
        {
            return new DataModels.DataPedido
            {
                Id = pedido.Id,
                ClienteId = pedido.ClienteId,
                ProdutoId = pedido.ProdutoId,
            };
        }


    }
}
