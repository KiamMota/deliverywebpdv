using Domain.Core.Entities;
using Domain.Core.Interfaces.Entities;
using Infra.Data.Database;
using Domain.Core.Interfaces;
using Infra.Data.Interfaces;


namespace Infra.Data.Repositories
{
    public class RepoPedido : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        public RepoPedido(AppDbContext obj)
        {
            _appDbContext = obj;
        }

        public int SalvarPedido(Pedido pedido)
        {
                _appDbContext.Pedidos.Add(pedido);
                _appDbContext.SaveChanges();
                return pedido.Id;
        }
        public IList<Pedido> SelectPedidoAll()
        {
            return _appDbContext.Pedidos.ToList();
        }
        public Pedido SelectPedidoById(int id)
        {
            var selectById = _appDbContext.Pedidos.FirstOrDefault(p => p.Id == id);
            if (selectById == null) return null;
            return selectById;
        }
        public bool PutPedidoById(Pedido Atualizado, int id)
        {
            if (Atualizado == null)
                return false;
            var putById = _appDbContext.Pedidos.FirstOrDefault(pid => pid.Id == id);
            
            if (putById == null)
            if (Atualizado.valorPedido != 0)
                putById.valorPedido = Atualizado.valorPedido;
                putById.nomePedido = Atualizado.nomePedido;
            if (Atualizado.quantidadePedido != 0)
                putById.quantidadePedido = Atualizado.quantidadePedido;
            _appDbContext.SaveChanges();
            return true;
        }

        public bool DeletePedidoById(int id)
        {
            var acharPedido = _appDbContext.Pedidos.FirstOrDefault(pid => pid.Id == id);
            if (acharPedido is null) return false;
            _appDbContext.Pedidos.Remove(acharPedido);
            _appDbContext.SaveChanges();
            return true;
        }
    }

}
