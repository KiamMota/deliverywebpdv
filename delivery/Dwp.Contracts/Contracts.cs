using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Delivery.Web.Pdv.Contracts
{
    
    public class PedidoDto
    {
        public Guid pedidoId = Guid.NewGuid();
        [Required]
        public string nomePedido { get; set; }
        [Required]
        [Range (1, 9999)]
        public decimal valorPedido { get; set; }
        [Required]
        [Range(1, 18)]
        public int quantidadePedido { get; set; }
        PedidoDto() => nomePedido = ""; /* para iniciar a string */

    }
}
