using Domain.Core.Pedido.Interfaces;

namespace Domain.Core.Entities
{
    public class Pedido : IPedido
    {
        public DateTime pedidoData { get; set; }
        public int pedidoId { get; set; }
        public string pedidoNome { get; set; } = "";
        public decimal pedidoValor { get; set; }
        public int pedidoQuantidade { get; set; }
    }
}
