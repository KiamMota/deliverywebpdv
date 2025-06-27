using Infra.Data.Database;
using Domain.Core.Repo.Interfaces;
using Domain.Core.Entities;

namespace Infra.Data.Repositories.RepoPedido
{
    public class RepoPedido : IRepoPedido
    {
        private readonly AppDbContext _appDbContext;
        public RepoPedido(AppDbContext obj)
        {
            _appDbContext = obj;
        }
        
        public int SalvarPedido(Domain.Core.Entities.Pedido pedido)
        {
            _appDbContext.pedidos.AddAsync(pedido);
            _appDbContext.SaveChanges();
            return pedido.pedidoId;
        }
        
        public IList<Domain.Core.Entities.Pedido> SelectPedidoAll()
        {
            var resultado = (from pedido in _appDbContext.pedidos select pedido).ToList();
            return resultado;
        }

        public Domain.Core.Entities.Pedido? SelectPedidoById(int id)
        {
            var selectById = _appDbContext.pedidos.FirstOrDefault(p => p.pedidoId == id);
            return selectById;
        }
        public bool PutPedidoById(Domain.Core.Entities.Pedido Atualizado, int id)
        {
            var putById = _appDbContext.pedidos.FirstOrDefault(pid => pid.pedidoId == id);
            
            if (Atualizado == null) return false;
            if (putById == null) return false;

            if(Atualizado.pedidoQuantidade > 0)
            {
                putById.pedidoQuantidade = Atualizado.pedidoQuantidade;
            }
            if (Atualizado.pedidoNome != null) 
            { 
                putById.pedidoNome = Atualizado.pedidoNome;
            }
            if (Atualizado.pedidoValor > 0)
            {
                putById.pedidoValor = Atualizado.pedidoValor;
            }
            return _appDbContext.SaveChanges() > 0;
        }

        public bool DeletePedidoById(int id)
        {
            var acharPedido = _appDbContext.pedidos.FirstOrDefault(pid => pid.pedidoId == id);
            if (acharPedido is null) return false;
            _appDbContext.pedidos.Remove(acharPedido);
            _appDbContext.SaveChanges();
            return true;
        }

        public Domain.Core.Entities.Pedido? SelectPedidoByNome(string nome)
        {
            /* linq para pedidoNome */
            var acharNome = (from pNome in _appDbContext.pedidos where pNome.pedidoNome == nome select pNome).FirstOrDefault();
            return acharNome;
        }
    }

}
