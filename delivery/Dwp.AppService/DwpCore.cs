using Delivery.Web.Pdv.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Web.Pdv.Core
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]

        public string nomePedido { get; set; }
        [Required]
        public decimal valorPedido { get; set; }
        [Required]
        [Range(1, 99)]
        public int quantidadePedido { get; set; }
        public Pedido() => nomePedido = ""; /* para iniciar a string */
    }

    internal interface IValidacao
    {
        public Pedido? ToPedido(PedidoDto dto);
        public PedidoDto? ToDto(Pedido pedido);
    }

    public class Validacao : IValidacao
    {
        public Pedido? ToPedido(PedidoDto dto)
        {
            if(dto is null) return null;
            else
            {
                Pedido realPedido = new Pedido();
                realPedido.nomePedido = dto.nomePedido;
                realPedido.valorPedido = dto.valorPedido;
                realPedido.quantidadePedido = dto.quantidadePedido;
                return realPedido;
            }
        }
        public PedidoDto? ToDto(Pedido pedido)
        {
            if (pedido is null) return null;
            else
            {
                PedidoDto pedidoDto = new PedidoDto();
                pedidoDto.nomePedido       = pedido.nomePedido;
                pedidoDto.valorPedido      = pedido.valorPedido;
                pedidoDto.quantidadePedido = pedido.quantidadePedido;
                return pedidoDto;
            }
        }
    }

    




}
