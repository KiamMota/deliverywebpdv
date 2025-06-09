using Contracts.Request;
using Contracts.Response;
using Domain.Core.Entities;

namespace AppService
{
    public class ObjectsConverter
    {
        public static Pedido FromPedidoRequest(PedidoRequest pedidoRq)
        {
            return new Pedido {
                nomePedido = pedidoRq.nomePedido,
                valorPedido = pedidoRq.valorPedido, 
                quantidadePedido = pedidoRq.quantidadePedido
            };
        }
        public static Pedido FromPedidoResponse(PedidoResponse pedidoRs)
        {
            return new Pedido
            {
                Id = pedidoRs.id,
                nomePedido = pedidoRs.nomePedido,
                valorPedido = pedidoRs.valorPedido,
                quantidadePedido = pedidoRs.quantidadePedido
            };
        }
    }
}
