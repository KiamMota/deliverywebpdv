using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Core;
using Delivery.Web.Pdv.Repository;

namespace Delivery.Web.Pdv.AppService
{ 
    public interface IAppService
    {
        public int CriarPedido(PedidoDto dto);
        public PedidoDto? EntregarPedido(int id);
        public PedidoDto? EntregarPedidoById(int id);
        public int AtualizarPedido(PedidoDto pedido);
        public int RemoverPedido(PedidoDto pedido);
    }

    public class AppService : IAppService
    {
        private readonly IRepository _repo;
        private readonly Validacao _validation;
        public AppService(IRepository repo)
        {
            _repo = repo; /* constructor */
            _validation = new Validacao();
        }
        public int CriarPedido(PedidoDto dto)
        {
            Pedido pedidoCriar = _validation.ToPedido(dto);
            if (pedidoCriar is null) return -1;
            else return _repo.SalvarPedido(pedidoCriar);
        }
        public int EntregarPedido(PedidoDto pedido)
        {
            Pedido pedidoEntregar = _validation.ToPedido(pedido);
            if (pedidoEntregar is null) return -1;
            return _repo.EntregarPedido(pedidoEntregar);
        }

        public PedidoDto? EntregarPedidoById(int id){ 
        {
                if (id == 0) { return null; }
                var pedido = new Pedido();
                pedido = _validation.ToDto(pedido);  
        }
        public int AtualizarPedido(PedidoDto pedido)
        {
            Pedido pedidoAtualizar = _validation.ToPedido(pedido);
            if (pedidoAtualizar is null) return -1;
            return _repo.AtualizarPedido(pedidoAtualizar);
        }
        public int RemoverPedido(PedidoDto pedido)
        {
            Pedido pedidoRemover = _validation.ToPedido(pedido);
            if(pedidoRemover is null) return -1;
            return _repo.DeletarPedido(pedidoRemover);

        }
    }
}