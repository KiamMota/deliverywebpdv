using Domain.Core.Entities;
using Infra.Data.Interfaces;
using Infra.Data.Database;
using System.Linq;
using CrossCutting.Log;
using System.Numerics;
using Delivery.Web.Pdv.Helper;



namespace Infra.Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private Log _log = new Log();

        public PedidoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool SalvarPedido(Pedido pedido)
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                _log.Insert("Houve algum erro com o banco de dados");
                _log.Insert("Õ Banco não pôde salvar o pedido");
                return false;
            }
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
            bool isIdValid = DwpHelper.No(Atualizado.Id);
            var putById = _appDbContext.Pedidos.FirstOrDefault(pid => pid.Id == id);
            
            if (isIdValid)
                return false;
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
