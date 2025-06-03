using Delivery.Web.Pdv.AppService;
using Delivery.Web.Pdv.Core.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Web.Pdv.Repository
{
    public interface IRepository
    {
        public IActionResult CreatePedido(Pedido pedido);
        public Pedido ReturnPedido(int id);
        public IActionResult QueryResult(int id);

    }
    public class DwpRepository : IRepository
    {
        public DwpRepository() 
        {
            
        }

        public IActionResult CreatePedido(Pedido pedido)
        {

        }
        public Pedido ReturnPedido(int id)
        {
            
        }
        public IActionResult QueryResult(int id)
        {
            return BadRequest();
        }

    }
}
