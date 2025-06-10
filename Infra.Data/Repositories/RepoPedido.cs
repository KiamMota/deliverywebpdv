using Infra.Data.Database;
using Domain.Core.Repo.Interfaces;
using Domain.Core.Entities.Pedido;

namespace Infra.Data.Repositories
{
    public class RepoPedido : IRepoPedido
    {
        private readonly AppDbContext _appDbContext;
        public RepoPedido(AppDbContext obj)
        {
            _appDbContext = obj;
        }

        public int SalvarPedido(DomainPedido pedido)
        {
                _appDbContext.Pedidos.Add(pedido);
                _appDbContext.SaveChanges();
                return pedido.id;
        }
        public IList<DomainPedido> SelectPedidoAll()
        {
            var resultado = (from pedido in _appDbContext.Pedidos select pedido).ToList();
            return resultado;
        }
        public DomainPedido SelectPedidoById(int id)
        {
            var selectById = _appDbContext.Pedidos.FirstOrDefault(p => p.id == id);
            if (selectById == null) return null;
            return selectById;
        }
        public bool PutPedidoById(DomainPedido Atualizado, int id)
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

        public DomainPedido? SelectPedidoByNome(string nome)
        {
            /* linq para nome */
            var acharNome = (from pNome in _appDbContext.Pedidos where pNome.nome == nome select pNome).FirstOrDefault();
            return acharNome;
        }



    }

}
