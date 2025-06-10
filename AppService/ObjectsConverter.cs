using Contracts.Request;
using Contracts.Response;
using Domain.Core.Entities.Pedido;

namespace AppService
{
    public class ObjectsConverter
    {
        /* dto -> domínio converte pedidorequest para pedido -> dominio */
        public static DomainPedido FromPedidoRequest(PedidoRequest pedidoRq)
        {
            return new DomainPedido
            {
                nome = pedidoRq.nomePedido,
                valor = pedidoRq.valorPedido,
                quantidade = pedidoRq.quantidadePedido
            };
        }
        
        /* dto -> domínio (de response para domínio real) */
        public static DomainPedido FromPedidoResponse(PedidoResponse pedidoRs)
        {
            return new DomainPedido
            {
                id = pedidoRs.id,
                nome = pedidoRs.nomePedido,
                valor = pedidoRs.valorPedido,
                quantidade = pedidoRs.quantidadePedido
            };
        }

        /* domínio -> dto; de pedido para pedidorequest */
        public static PedidoRequest? ToPedidoRequest(DomainPedido pedido)
        {
            if (pedido == null) return null;
            return new PedidoRequest
            {
                nomePedido = pedido.nome,
                valorPedido = pedido.valor,
                quantidadePedido = pedido.quantidade
            };
        }

        /* domínio -> dto; de pedido para pedidoResposne */
        public static PedidoResponse? ToPedidoResponse(DomainPedido pedido)
        {
            if (pedido == null)
                return null;

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
