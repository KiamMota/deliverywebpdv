using Domain.Core.Interfaces.Entities;

namespace Contracts.Base
{
    public class PedidoBase : IPedido
    {
        public int Id { get ; set ; }
        public string nomePedido { get; set; } = "";
        public decimal valorPedido { get ; set ; }
        public int quantidadePedido { get ; set ; }
    }
}
