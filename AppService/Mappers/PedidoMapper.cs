using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;
using Domain.Core.Entities;

namespace AppService.Mappers
{
    public sealed class PedidoMapper
    {
        /* dto -> domínio converte pedidorequest para pedido -> dominio */
        public static Pedido FromPedidoRequest(PedidoRequest pedidoRq)
        {
            return new Pedido
            {
                pedidoData = pedidoRq.pedidoData,
                pedidoNome = pedidoRq.pedidoNome,
                pedidoValor = pedidoRq.pedidoValor.Value,
                pedidoQuantidade = pedidoRq.pedidoQuantidade.Value,
            };
        }

        /* dto -> domínio (de response para domínio real) */
        public static Pedido FromPedidoResponse(PedidoResponse pedidoRs)
        {
            return new Pedido
            {
                pedidoId = pedidoRs.id,
                pedidoData = pedidoRs.data,
                pedidoNome = pedidoRs.nome,
                pedidoValor = pedidoRs.valor,
                pedidoQuantidade = pedidoRs.quantidade
            };
        }

        /* domínio -> dto; de pedido para pedidorequest */
        public static PedidoRequest? ToPedidoRequest(Pedido pedido)
        {
            if (pedido == null) return null;
            return new PedidoRequest
            {
                pedidoNome = pedido.pedidoNome,
                pedidoValor = pedido.pedidoValor,
                pedidoQuantidade = pedido.pedidoQuantidade
            };
        }

        /* domínio -> dto; de pedido para pedidoResposne */
        public static PedidoResponse? ToPedidoResponse(Pedido pedido)
        {
            if (pedido == null)
                return null;

            return new PedidoResponse
            {
                data = pedido.pedidoData,
                id = pedido.pedidoId,
                nome = pedido.pedidoNome,
                valor = pedido.pedidoValor,
                quantidade = pedido.pedidoQuantidade
            };
        }
    }
}
