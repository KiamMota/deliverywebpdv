using System.ComponentModel.DataAnnotations;

namespace Delivery.Web.Pdv.Contracts
{
  
    public class PedidoDto
    {
        public int idPedido { set; get; }
        public string nomePedido { get; set; }
        public decimal valorPedido { get; set; }
        public int quantidadePedido { get; set; }
        public PedidoDto() => nomePedido = ""; /* para iniciar a string */
    }
}
