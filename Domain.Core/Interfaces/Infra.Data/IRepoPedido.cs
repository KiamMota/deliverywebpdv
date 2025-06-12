namespace Domain.Core.Repo.Interfaces
{
    public interface IRepoPedido
    {
        int SalvarPedido(Entities.Domain pedido);
        IList<Entities.Domain> SelectPedidoAll();
        Entities.Domain? SelectPedidoById(int id);
        Entities.Domain? SelectPedidoByNome(string nome);
        bool PutPedidoById(Entities.Domain Atualizado, int id);
        bool DeletePedidoById(int id);
    }
}