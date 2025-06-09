using Contracts.Request;
using Contracts.Response;
using Domain.Core.Entities;

namespace AppService
{
    public class ObjectsConverter
    {
        // Converte de PedidoRequest para Pedido (domínio)
        public static Pedido FromPedidoRequest(PedidoRequest pedidoRq)
        {
            return new Pedido
            {
                nomePedido = pedidoRq.nomePedido,
                valorPedido = pedidoRq.valorPedido,
                quantidadePedido = pedidoRq.quantidadePedido
            };
        }

        // Converte de PedidoResponse para Pedido (domínio)
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

        // Converte de Pedido (domínio) para PedidoRequest
        public static PedidoRequest ToPedidoRequest(Pedido pedido)
        {
            return new PedidoRequest
            {
                nomePedido = pedido.nomePedido,
                valorPedido = pedido.valorPedido,
                quantidadePedido = pedido.quantidadePedido
            };
        }

        // Converte de Pedido (domínio) para PedidoResponse
        public static PedidoResponse ToPedidoResponse(Pedido pedido)
        {
            return new PedidoResponse
            {
                id = pedido.Id,
                nomePedido = pedido.nomePedido,
                valorPedido = pedido.valorPedido,
                quantidadePedido = pedido.quantidadePedido
            };
        }
    }
}
