using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Domain;
using Delivery.Web.Pdv.Repository;

namespace Delivery.Web.Pdv.AppService
{ 
    public interface IAppService
    {
        public int CriarPedido(PedidoDto dto);
        public PedidoDto? EntregarPedidoById(int id);
        public bool AtualizarPedido(int id);
        public bool RemoverPedido(int id);
    }

    public class AppService : IAppService
    {
        private readonly IRepository _repo;
        private readonly IDto2O _dto2o;
        public AppService(IRepository repo, IDto2O dto2o)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
            _dto2o = dto2o ?? throw new ArgumentNullException(nameof(dto2o));
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

        public bool AtualizarPedido(int id) => _repo.AtualizarPedidoById(id) != null; 
        public bool RemoverPedido(int id)   => _repo.DeletarPedidoById(id);
           
    }
}