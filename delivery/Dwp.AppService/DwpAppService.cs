using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Core;
using Delivery.Web.Pdv.Helper;
using Delivery.Web.Pdv.Repository;
using Delivery.Web.Pdv.Database;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace Delivery.Web.Pdv.AppService
{ 
    public interface IAppService
    {
        public int CriarPedido(PedidoDto dto);
        public int EntregarPedido(PedidoDto pedido);
    }

    public class AppService : IAppService
    {
        private IValidacao  _validation = new Validacao();
        private static Database.Database _db = new Database.Database();
        private IRepository _repo = new Repository.Repository(_db);
        public int CriarPedido(PedidoDto dto)
        {
            Pedido pedidoCriar = _validation.ToPedido(dto);
            if (pedidoCriar is null) return 0;
            else return _repo.SalvarPedido(pedidoCriar);
        }
        public int EntregarPedido(PedidoDto pedido)
        {
            Pedido pedidoEntregar = _validation.ToPedido(pedido);
            return _repo.EntregarPedido(pedidoEntregar);
        }

    }
}