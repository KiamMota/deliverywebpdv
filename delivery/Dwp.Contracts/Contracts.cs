using System.ComponentModel.DataAnnotations;


namespace Delivery.Web.Pdv.Contracts
{
    public class PedidoRequest
    {
        public Guid pedidoId;
        [Required]
        public string nomePedido { get; set; }
        [Required]
        [Range (1, 9999)]
        public decimal valorPedido { get; set; }
        [Required]
        [Range(1, 18)]
        public int quantidadePedido { get; set; }
        public PedidoRequest() => nomePedido = ""; /* para iniciar a string */
    }
}
