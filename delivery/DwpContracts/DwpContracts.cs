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
        public string nomePedido { get; set; }
        public decimal valorPedido { get; set; }
        public int quantidadePedido { get; set; }
        public PedidoDto() => nomePedido = ""; /* para iniciar a string */
    }
}
