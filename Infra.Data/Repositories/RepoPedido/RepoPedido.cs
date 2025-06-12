using Infra.Data.Database;
using Domain.Core.Repo.Interfaces;

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
            _appDbContext.pedidos.Add(pedido);
            _appDbContext.SaveChanges();
            return pedido.id;
        }
        public IList<Domain.Core.Entities.Pedido> SelectPedidoAll()
        {
            var resultado = (from pedido in _appDbContext.pedidos select pedido).ToList();
            return resultado;
        }
        public Domain.Core.Entities.Pedido? SelectPedidoById(int id)
        {
            var selectById = _appDbContext.pedidos.FirstOrDefault(p => p.id == id);
            if (selectById == null) return null;
            return selectById;
        }
        public bool PutPedidoById(Domain.Core.Entities.Pedido Atualizado, int id)
        {
            var putById = _appDbContext.pedidos.FirstOrDefault(pid => pid.id == id);
            
            if (Atualizado == null) return false;
            if (putById == null) return false;

            if(Atualizado.quantidade > 0)
            {
                putById.quantidade = Atualizado.quantidade;
            }
            if (Atualizado.nome != null) 
            { 
                putById.nome = Atualizado.nome;
            }
            if (Atualizado.valor > 0)
            {
                putById.valor = Atualizado.valor;
            }

            return _appDbContext.SaveChanges() > 0;
            
        }

        public bool DeletePedidoById(int id)
        {
            var acharPedido = _appDbContext.pedidos.FirstOrDefault(pid => pid.id == id);
            if (acharPedido is null) return false;
            _appDbContext.pedidos.Remove(acharPedido);
            _appDbContext.SaveChanges();
            return true;
        }

        public Domain.Core.Entities.Pedido? SelectPedidoByNome(string nome)
        {
            /* linq para nome */
            var acharNome = (from pNome in _appDbContext.pedidos where pNome.nome == nome select pNome).FirstOrDefault();
            return acharNome;
        }



    }

}
