using Domain.Core.Interfaces.Entities.Pedido;

namespace Contracts.PedidoContracts.Base
{
    public class PedidoBase : IPedido
    {
        public DateTime data { get; set; }
        public int id { get; set; }
        public string nome { get; set; } = "";
        public decimal valor { get; set; }
        public int quantidade { get; set; }
    }
}
