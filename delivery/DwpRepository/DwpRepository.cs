using Delivery.Web.Pdv.Core;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Database;

using Microsoft.EntityFrameworkCore;

namespace Delivery.Web.Pdv.Repository
{
    public interface IRepository
    {
        public int SalvarPedido(Pedido pedido);
        public int EntregarPedido(Pedido pedido);
        public int AtualizarPedido(Pedido pedido);
        public int DeletarPedido(Pedido pedido);
    
    }

    public class Repository : IRepository
    {
        private readonly Database.Database _context;
        private Core.IValidacao _validacao = new Validacao();
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
        public int EntregarPedido(Pedido pedido)
        {
            _context.Pedidos.Find(pedido.Id);
            _context.SaveChanges();
            return pedido.Id;

        }
        public int AtualizarPedido(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
            return pedido.Id;
        }
        public int DeletarPedido(Pedido pedido)
        {
            _context.Pedidos.Remove(pedido);
            return (_context.SaveChanges() > 0) ? 1 : 0;
            
        }
    }
}