using Domain.Core.Entities.Pedido;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IPedidoRepo
    {
        long Salvar(Pedido entity);
        Pedido? GetById(long id);
        bool PutById(Pedido entity, long id);
        bool DeleteById(long id);
        IList<Pedido> ReadAll();
    }
}
