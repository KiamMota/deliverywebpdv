using Domain.Core.Pedido.Interfaces;

namespace Domain.Core.Entities
{
    public class Domain : IPedido
    {
        public DateTime data { get; set; } = DateTime.UtcNow;
        public int id { get; set; }
        public string nome { get; set; } = "";
        public decimal valor { get; set; }
        public int quantidade { get; set; }
    }
}
