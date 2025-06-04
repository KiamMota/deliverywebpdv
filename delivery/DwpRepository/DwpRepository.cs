using Delivery.Web.Pdv.Core;
using Delivery.Web.Pdv.Contracts;

namespace Delivery.Web.Pdv.Repository
{
    public interface IRepository
    {
        public bool SalvarPedido(Pedido pedido);
        public PedidoDto? EntregarPedido(int id);
        public bool AtualizarPedido(int id);
        public bool DeletarPedido(int id);
    
    }

    public class Repository : IRepository
    {
      
        public bool SalvarPedido(Pedido pedido)
        {
            return false;
        }
        public PedidoDto? EntregarPedido(int id)
        {
            /* todo lógica do banco */
            return new PedidoDto();
        }
        public bool AtualizarPedido(int id)
        {
            return false;
        }
        public bool DeletarPedido(int id)
        {
            return false;
        }
    }
}