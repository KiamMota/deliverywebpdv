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
                nome = pedidoRq.nomePedido,
                valor = pedidoRq.valorPedido,
                quantidade = pedidoRq.quantidadePedido
            };
        }

        // Converte de PedidoResponse para Pedido (domínio)
        public static Pedido FromPedidoResponse(PedidoResponse pedidoRs)
        {
            return new Pedido
            {
                id = pedidoRs.id,
                nome = pedidoRs.nomePedido,
                valor = pedidoRs.valorPedido,
                quantidade = pedidoRs.quantidadePedido
            };
        }

        // Converte de Pedido (domínio) para PedidoRequest
        public static PedidoRequest ToPedidoRequest(Pedido pedido)
        {
            return new PedidoRequest
            {
                nomePedido = pedido.nome,
                valorPedido = pedido.valor,
                quantidadePedido = pedido.quantidade
            };
        }

        // Converte de Pedido (domínio) para PedidoResponse
        public static PedidoResponse ToPedidoResponse(Pedido pedido)
        {
            return new PedidoResponse
            {
                id = pedido.id,
                nomePedido = pedido.nome,
                valorPedido = pedido.valor,
                quantidadePedido = pedido.quantidade
            };
        }
    }
}
