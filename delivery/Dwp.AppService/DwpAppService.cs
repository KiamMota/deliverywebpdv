using System.ComponentModel.DataAnnotations;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Core.Entity;
using Delivery.Web.Pdv.Repository;


namespace Delivery.Web.Pdv.AppService
{
    public class AppService
    {
       
        public static Pedido ParaPedido(PedidoDto dto)
        {
            return new Pedido
            {
                nomePedido = dto.nomePedido,
                valorPedido = dto.valorPedido,
                quantidadePedido = dto.quantidadePedido
            };
        }

        public static PedidoDto ParaPedidoDto(Pedido pedido)
        {
            return new PedidoDto
            {
                nomePedido = pedido.nomePedido,
                valorPedido = pedido.valorPedido,
                quantidadePedido = pedido.quantidadePedido
            };


        }


    }







}