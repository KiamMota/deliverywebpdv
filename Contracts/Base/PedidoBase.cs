using Domain.Core.Interfaces.Entities;

namespace Contracts.Base
{
    public class PedidoBase : IPedido
    {
        public int id { get ; set ; }
        public string nome { get; set; } = "";
        public decimal valor { get ; set ; }
        public int quantidade { get ; set ; }
    }
}
