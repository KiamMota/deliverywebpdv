using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities.Pedido
{
    public class Pedido : IAggregateRoot
    {
        public long Id { get; set; }
        public long ProdutoId { get; private set; }
        public long ClienteId { get; private set; }

        public Pedido(long ProdutoId, long ClienteId)
        {
            this.ProdutoId = ProdutoId;
            this.ClienteId = ClienteId;
        }
    }
}
