using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;
using Domain.Core.Entities;

namespace AppService
{
    public sealed class PedidoMapper
    {
        /* dto -> domínio converte pedidorequest para pedido -> dominio */
        public static Domain.Core.Entities.Pedido FromPedidoRequest(PedidoRequest pedidoRq)
        {
            return new Domain.Core.Entities.Pedido
            {
                pedidoData      =  pedidoRq.pedidoData,
                pedidoNome      =  pedidoRq.pedidoNome,
                pedidoValor    =   pedidoRq.pedidoValor.Value,
                pedidoQuantidade = pedidoRq.pedidoQuantidade.Value,
            };
        }

        /* dto -> domínio (de response para domínio real) */
        public static Domain.Core.Entities.Pedido FromPedidoResponse(PedidoResponse pedidoRs)
        {
            return new Domain.Core.Entities.Pedido
            {
                pedidoId    = pedidoRs.id,
                pedidoData  = pedidoRs.data,
                pedidoNome  = pedidoRs.nome,
                pedidoValor = pedidoRs.valor,
                pedidoQuantidade = pedidoRs.quantidade
            };
        }

        /* domínio -> dto; de pedido para pedidorequest */
        public static PedidoRequest? ToPedidoRequest(Domain.Core.Entities.Pedido pedido)
        {
            if (pedido == null) return null;
            return new PedidoRequest
            {
                pedidoNome       = pedido.pedidoNome,
                pedidoValor      = pedido.pedidoValor,
                pedidoQuantidade = pedido.pedidoQuantidade
            };
        }

        /* domínio -> dto; de pedido para pedidoResposne */
        public static PedidoResponse? ToPedidoResponse(Domain.Core.Entities.Pedido pedido)
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
