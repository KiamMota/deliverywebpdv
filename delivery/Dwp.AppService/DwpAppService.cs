using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Domain;
using Delivery.Web.Pdv.Repository;

namespace Delivery.Web.Pdv.AppService
{ 
    public interface IAppService
    {
        public int CriarPedido(PedidoDto dto);
        public PedidoDto? EntregarPedidoById(int id);
        public int AtualizarPedido(PedidoDto pedido);
        public int RemoverPedido(PedidoDto pedido);
    }

    public class AppService : IAppService
    {
        private readonly IRepository _repo;
        private readonly Dto2O _dto2o;
        public AppService(IRepository repo)
        {
            _repo = repo; /* constructor */
        }
        public int CriarPedido(PedidoDto dto)
        {
            Pedido pedidoCriar = _dto2o.ToPedido(dto);
            if (pedidoCriar is null) return -1;
            else return _repo.SalvarPedido(pedidoCriar);
        }

        public PedidoDto? EntregarPedidoById(int id)
        {
            if (id == 0) return null;

            Pedido? pedido = _repo.EntregarPedidoById(id);
            if (pedido == null) return null;

            /* mudar dto2o para mapper */
            PedidoDto pedidodto = _dto2o.ToDto(pedido);
            return pedidodto;
        }

        public int AtualizarPedido(PedidoDto pedido)
        {
            Pedido pedidoAtualizar = _dto2o.ToPedido(pedido);
            if (pedidoAtualizar is null) return -1;
            return _repo.AtualizarPedido(pedidoAtualizar);
        }
        public int RemoverPedido(PedidoDto pedido)
        {
            Pedido pedidoRemover = _dto2o.ToPedido(pedido);
            if(pedidoRemover is null) return -1;
            return _repo.DeletarPedido(pedidoRemover);

        }
    }
}