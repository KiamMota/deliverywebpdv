
namespace Domain.Core.Interfaces.Entities
{
    public interface IPedido
    {
        int id { get; set; }
        string nome { get; set; }
        decimal valor { get; set; }
        int quantidade { get; set; }
    }
}
