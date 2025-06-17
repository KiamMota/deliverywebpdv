namespace Domain.Core.Repo.Interfaces
{
    public interface IRepoPedido
    {
        Task<int> SalvarPedido(Entities.Pedido pedido);
        Task<IList<Entities.Pedido>> SelectPedidoAll();
        Task<Entities.Pedido?> SelectPedidoById(int id);
        Task<Entities.Pedido?> SelectPedidoByNome(string nome);
        Task<bool> PutPedidoById(Entities.Pedido Atualizado, int id);
        Task<bool> DeletePedidoById(int id);
    }
}