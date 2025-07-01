using Contracts.VModels.Pedido;
using Domain.Core.Entities;

namespace AppService.Mappers
{
    public sealed class PedidoMapper
    {
        /* dto -> domínio converte pedidorequest para pedido -> dominio */
        public static Pedido FromPedidoRequest(PedidoRequest pedidoRq)
        {
            
            var pedido = new Pedido(
                nome:       pedidoRq.Name,
                quantidade: pedidoRq.Quantidade,
                valor:      pedidoRq.Valor);
            
            return pedido;
        }

        /* dto -> domínio (de response para domínio real) */
        public static Pedido FromPedidoResponse(PedidoResponse pedidoRs)
        {
            var pedido = new Pedido(
                nome: pedidoRs.Nome,
                quantidade: pedidoRs.Quantidade,
                valor: pedidoRs.Valor);

            return pedido;
        }

        /* domínio -> dto; de pedido para pedidorequest */
        public static PedidoRequest? ToPedidoRequest(Pedido pedido)
        {
            if (pedido == null) return null;
            return new PedidoRequest
            {
                Name = pedido.Nome._Name,
                Valor = pedido.Valor._Valor,
                Quantidade = pedido.Quantidade._Quantidade
            };
        }

        /* domínio -> dto; de pedido para pedidoResposne */
        public static PedidoResponse? ToPedidoResponse(Pedido pedido)
        {
            if (pedido == null)
                return null;

            return new PedidoResponse
            {
                Id         = pedido.Id,
                Nome       = pedido.Nome._Name,
                Data       = pedido.Data.Date,
                Valor      = pedido.Valor._Valor,
                Quantidade = pedido.Quantidade._Quantidade
            };
        }
    }
}
