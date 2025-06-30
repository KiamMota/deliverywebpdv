using Domain.Core.Entities.Interfaces;

namespace Domain.Core.Entities
{
    public class Pedido : IEntityBase
    {
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public DateTime pedidoData { get; set; }
        public decimal pedidoValor { get; set; }
        public int pedidoQuantidade { get; set; }
    }
}
