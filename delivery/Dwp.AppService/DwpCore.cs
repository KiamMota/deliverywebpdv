using System.ComponentModel.DataAnnotations;

namespace Delivery.Web.Pdv.Core.Entity
{
        public abstract class PedidoRequestBase
        {
            [Required]
            long idPedido { get; set; }
        }
        public class Pedido : PedidoRequestBase
        {
            [Required]
            public string nomePedido { get; set; }
            [Required]
            [Range(1, 9999)]
            public decimal valorPedido { get; set; }
            [Required]
            [Range(1, 18)]
            public int quantidadePedido { get; set; }
            public Pedido() => nomePedido = ""; /* para iniciar a string */
        }


}
