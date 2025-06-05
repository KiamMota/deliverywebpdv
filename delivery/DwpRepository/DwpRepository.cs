using Delivery.Web.Pdv.Domain;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Database;

using Microsoft.EntityFrameworkCore;

namespace Delivery.Web.Pdv.Repository
{
    public interface IRepository
    {
        public int SalvarPedido(Pedido pedido);
        public Pedido? EntregarPedidoById(int id);
        public Pedido? AtualizarPedidoById(int id);
        public bool DeletarPedidoById(int id);
    
    }
    public class Repository : IRepository
    {
        private readonly Database.Database _context;
        private Dto2O dto = new Dto2O();
        public Repository(Database.Database context)
        {
            _context = context;
        }
        public int SalvarPedido(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return pedido.Id;
        }

        public Pedido? EntregarPedidoById(int id)
        {
            return _context.Pedidos.Find(id);
        }
        public Pedido? AtualizarPedidoById(int id)
        {
            Pedido? pedidoToUpdate = new Pedido();
            pedidoToUpdate.Id = id;
            _context.Pedidos.Update(pedidoToUpdate);
            _context.SaveChanges();
            return pedidoToUpdate;
        }
        public bool DeletarPedidoById(int id)
        {
            Pedido? pedidoToRemove = new Pedido();
            pedidoToRemove.Id = id;
            _context.Pedidos.Remove(pedidoToRemove);
            return _context.SaveChanges() > 0;
            
        }
    }
}