using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities.Pedido
{
    public class Pedido : IAggregateRoot
    {
        [Key]
        public long Id { get; set; }
        public Guid ProdutoId { get; private set; }
        public Guid ClienteId { get; private set; }

        public Pedido(Guid ProdutoId, Guid ClienteId)
        {
            this.ProdutoId = ProdutoId;
            this.ClienteId = ClienteId;
        }
    }
}
