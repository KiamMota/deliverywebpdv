using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;
using Domain.Core.Entities.Pedido;

namespace AppService
{
    public class ObjectsConverter
    {
        /* dto -> domínio converte pedidorequest para pedido -> dominio */
        public static Pedido FromPedidoRequest(PedidoRequest pedidoRq)
        {
            return new Pedido
            {
                data = pedidoRq.data,
                nome = pedidoRq.nomePedido,
                valor = pedidoRq.valorPedido,
                quantidade = pedidoRq.quantidadePedido
            };
        }
        
        /* dto -> domínio (de response para domínio real) */
        public static Pedido FromPedidoResponse(PedidoResponse pedidoRs)
        {
            return new Pedido
            {
                id = pedidoRs.id,
                data = pedidoRs.data,
                nome = pedidoRs.nomePedido,
                valor = pedidoRs.valorPedido,
                quantidade = pedidoRs.quantidadePedido
            };
        }

        /* domínio -> dto; de pedido para pedidorequest */
        public static PedidoRequest? ToPedidoRequest(Pedido pedido)
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
        public static PedidoResponse? ToPedidoResponse(Pedido pedido)
        {
            if (pedido == null)
                return null;

            return new PedidoResponse
            {
                data = pedido.data,
                id = pedido.id,
                nomePedido = pedido.nome,
                valorPedido = pedido.valor,
                quantidadePedido = pedido.quantidade
            };
        }
    }
}
