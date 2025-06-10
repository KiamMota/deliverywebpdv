using Domain.Core.Entities;
using Domain.Core.Interfaces.Entities;
using Infra.Data.Database;
using Domain.Core.Interfaces;
using Domain.Core.Repo.Interfaces;


namespace Infra.Data.Repositories
{
    public class RepoPedido : IRepoPedido
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
                return pedido.id;
        }
        public IList<Pedido> SelectPedidoAll()
        {
            return _appDbContext.Pedidos.ToList();
        }
        public Pedido SelectPedidoById(int id)
        {
            var selectById = _appDbContext.Pedidos.FirstOrDefault(p => p.id == id);
            if (selectById == null) return null;
            return selectById;
        }
        public bool PutPedidoById(Pedido Atualizado, int id)
        {
            if (Atualizado == null)
                return false;
            var putById = _appDbContext.Pedidos.FirstOrDefault(pid => pid.id == id);
            
            if (putById == null)
            if (Atualizado.valor != 0)
                putById.valor = Atualizado.valor;
                putById.nome = Atualizado.nome;
            if (Atualizado.quantidade != 0)
                putById.quantidade = Atualizado.quantidade;
            _appDbContext.SaveChanges();
            return true;
        }

        public bool DeletePedidoById(int id)
        {
            var acharPedido = _appDbContext.Pedidos.FirstOrDefault(pid => pid.id == id);
            if (acharPedido is null) return false;
            _appDbContext.Pedidos.Remove(acharPedido);
            _appDbContext.SaveChanges();
            return true;
        }
    }

}
