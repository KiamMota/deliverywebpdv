
namespace Domain.Core.Interfaces.Entities
{
    public interface IPedido
    {
        int Id { get; set; }
        string nomePedido { get; set; }
        decimal valorPedido { get; set; }
        int quantidadePedido { get; set; }
    }
}
