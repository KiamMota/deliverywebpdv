namespace Domain.Core.Pedido.Interfaces
{
    public interface IPedido
    {
        DateTime pedidoData   { get; set; }
        int     pedidoId      { get; set; }
        string  pedidoNome    { get; set; }
        decimal pedidoValor   { get; set; }
        int     pedidoQuantidade  { get; set; }
    }
}