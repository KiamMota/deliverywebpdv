using Domain.Core.Entities.Base;

namespace Domain.Core.Entities.Interfaces
{
    public interface IPedido : IEntity
    {
        DateTime pedidoData { get; set; }
        int pedidoId { get; set; }
        string pedidoNome { get; set; }
        decimal pedidoValor { get; set; }
        int pedidoQuantidade { get; set; }
    }
}