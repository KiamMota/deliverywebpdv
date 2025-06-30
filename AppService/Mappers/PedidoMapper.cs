using Contracts.VModels.Pedido;
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
                pedidoData = pedidoRq.Data,
                Name = pedidoRq.Name,
                pedidoValor = pedidoRq.Valor.Value,
                pedidoQuantidade = pedidoRq.Quantidade.Value,
            };
        }

        /* dto -> domínio (de response para domínio real) */
        public static Pedido FromPedidoResponse(PedidoResponse pedidoRs)
        {
            return new Pedido
            {
                Id = pedidoRs.id,
                Name = pedidoRs.nome,
                pedidoData = pedidoRs.data,
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
                Name = pedido.Name,
                Valor = pedido.pedidoValor,
                Quantidade = pedido.pedidoQuantidade
            };
        }

        /* domínio -> dto; de pedido para pedidoResposne */
        public static PedidoResponse? ToPedidoResponse(Pedido pedido)
        {
            if (pedido == null)
                return null;

            return new PedidoResponse
            {
                id = pedido.Id,
                nome = pedido.Name,
                data = pedido.pedidoData,
                valor = pedido.pedidoValor,
                quantidade = pedido.pedidoQuantidade
            };
        }
    }
}
