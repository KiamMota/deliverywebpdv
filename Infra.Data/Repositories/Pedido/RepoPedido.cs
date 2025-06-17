using Infra.Data.Database;
using Domain.Core.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories.RepoPedido
{
    public class RepoPedido : IRepoPedido
    {
        private readonly AppDbContext _appDbContext;
        public RepoPedido(AppDbContext obj)
        {
            _appDbContext = obj;
        }
        
        public async Task<int> SalvarPedido(Domain.Core.Entities.Pedido pedido)
        {
            await _appDbContext.pedidos.AddAsync(pedido);
            await _appDbContext.SaveChangesAsync();
            return pedido.pedidoId;
        }
        
        public async Task<IList<Domain.Core.Entities.Pedido>> SelectPedidoAll()
        {
            var resultado = await (from pedido in _appDbContext.pedidos select pedido).ToListAsync();
            return resultado;
        }

        public async Task<Domain.Core.Entities.Pedido>? SelectPedidoById(int id)
        {
            var selectById = await _appDbContext.pedidos.FirstOrDefaultAsync(p => p.pedidoId == id);
            return selectById;
        }
        public async Task<bool> PutPedidoById(Domain.Core.Entities.Pedido Atualizado, int id)
        {
            var putById = await _appDbContext.pedidos.FirstOrDefaultAsync(pid => pid.pedidoId == id);
            
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

        public async Task<bool> DeletePedidoById(int id)
        {
            var acharPedido = await _appDbContext.pedidos.FirstOrDefaultAsync(pid => pid.pedidoId == id);
            if (acharPedido is null) return false;
            _appDbContext.pedidos.Remove(acharPedido);
            _appDbContext.SaveChanges();
            return true;
        }

        public async Task<Domain.Core.Entities.Pedido>? SelectPedidoByNome(string nome)
        {
            /* linq para pedidoNome */
            var acharNome = await (from pNome in _appDbContext.pedidos where pNome.pedidoNome == nome select pNome).FirstOrDefaultAsync();
            return acharNome;
        }



    }

}
