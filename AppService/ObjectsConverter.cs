using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;
using Domain.Core.Entities.Pedido;

namespace AppService
{
    public class ObjectsConverter
    {
        /* dto -> domínio converte pedidorequest para pedido -> dominio */
        public static Domain.Core.Entities.Pedido.Domain FromPedidoRequest(PedidoRequest pedidoRq)
        {
            return new Domain.Core.Entities.Pedido.Domain
            {
                data = pedidoRq.data,
                nome = pedidoRq.nomePedido,
                valor = pedidoRq.valorPedido,
                quantidade = pedidoRq.quantidadePedido
            };
        }
        
        /* dto -> domínio (de response para domínio real) */
        public static Domain.Core.Entities.Pedido.Domain FromPedidoResponse(PedidoResponse pedidoRs)
        {
            return new Domain.Core.Entities.Pedido.Domain
            {
                id = pedidoRs.id,
                data = pedidoRs.data,
                nome = pedidoRs.nome,
                valor = pedidoRs.valor,
                quantidade = pedidoRs.quantidade
            };
        }

        /* domínio -> dto; de pedido para pedidorequest */
        public static PedidoRequest? ToPedidoRequest(Domain.Core.Entities.Pedido.Domain pedido)
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
        public static PedidoResponse? ToPedidoResponse(Domain.Core.Entities.Pedido.Domain pedido)
        {
            if (pedido == null)
                return null;

            return new PedidoResponse
            {
                data = pedido.data,
                id = pedido.id,
                nome = pedido.nome,
                valor = pedido.valor,
                quantidade = pedido.quantidade
            };
        }
    }
}
