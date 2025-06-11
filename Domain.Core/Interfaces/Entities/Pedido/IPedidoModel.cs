namespace Domain.Core.Interfaces.Entities.Pedido
{
    public interface IPedidoModel
    {
        DateTime data { get; set; }
        int id { get; set; }
        string nome { get; set; }
        decimal valor { get; set; }
        int quantidade { get; set; }
    }
}
