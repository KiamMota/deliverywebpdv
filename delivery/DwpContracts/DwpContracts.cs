using System.ComponentModel.DataAnnotations;

namespace Delivery.Web.Pdv.Contracts
{
    public abstract class PedidoRequestBase
    {
        [Required]
        long idPedido { get; set; }
    }
    public class PedidoDto : PedidoRequestBase
    {
        [Required]
        public string nomePedido { get; set; }
        [Required]
        [Range(1, 9999)]
        public decimal valorPedido { get; set; }
        [Required]
        [Range(1, 18)]
        public int quantidadePedido { get; set; }
        public PedidoDto() => nomePedido = ""; /* para iniciar a string */

    }
}
