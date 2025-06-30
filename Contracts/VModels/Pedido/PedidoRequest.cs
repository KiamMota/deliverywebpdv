using System.ComponentModel.DataAnnotations;

namespace Contracts.VModels.Pedido
{
    public class PedidoRequest
    {
        public DateTime Data { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public decimal? Valor { get; set; }
        [Required]
        public int? Quantidade { get; set; }
    }
}