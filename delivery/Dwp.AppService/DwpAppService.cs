using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Core;
using Delivery.Web.Pdv.Helper;
using Delivery.Web.Pdv.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace Delivery.Web.Pdv.AppService
{ 
    public interface IAppService
    {
        public bool CriarPedido(PedidoDto dto);
        public PedidoDto? EntregarPedido(int id);
    }

    public class AppService : IAppService
    {
        private IValidacao  _validation = new Validacao();
        private IRepository _repo = new Repository.Repository();
        public bool CriarPedido(PedidoDto dto)
        {
            Pedido pedidoCriar = _validation.ToPedido(dto);
            if (pedidoCriar is null) return false;
            else
                return _repo.SalvarPedido(pedidoCriar);
        }
        public PedidoDto EntregarPedido(int id)
        {
            var pedidoEntregar = _repo.EntregarPedido(id);
            if (pedidoEntregar == null)
            {
                return null;
            }
            return pedidoEntregar;
        }

    }
}