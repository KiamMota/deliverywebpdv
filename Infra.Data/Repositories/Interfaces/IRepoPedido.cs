namespace Domain.Core.Repo.Interfaces
{
    public interface IRepoPedido
    {
        int SalvarPedido(Entities.Pedido pedido);
        IList<Entities.Pedido> SelectPedidoAll();
        Entities.Pedido? SelectPedidoById(int id);
        Entities.Pedido? SelectPedidoByNome(string nome);
        bool PutPedidoById(Entities.Pedido Atualizado, int id);
        bool DeletePedidoById(int id);
    }
}