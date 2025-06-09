using Contracts.Request;
using Contracts.Response;
using Domain.Core.Validation;
using Infra.Data.Repositories;
using AppService.Interfaces;

namespace AppService
{
    public class ProcessPedido : IProcessPedido
    {
        private PedidoValidation _validation = new PedidoValidation();
        private PedidoRepository _repository = new PedidoRepository();
        public int SalvarPedido(PedidoRequest pedido)
        {
            if (pedido == null) throw new ArgumentNullException("pedido é nulo!");
            return 0;
        }
        public PedidoResponse? PegarPedidoById(int id)
        {
            

            return null;
        }
        public bool AlterarPedidoById(int id)
        {

        }
        public bool RemoverPedidoById(int id)
        {


        }

    }


}