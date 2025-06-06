using Contracts.Request;
using Contracts.Response;
using Domain.Core.Validation;
using AppService.Interfaces;



namespace AppService
{
    public class ProcessPedido : IProcessPedido
    {
        private PedidoValidation _validation = new PedidoValidation();
        
        public int SalvarPedido(PedidoRequest pedido)
        {
            
        }
        public PedidoResponse PegarPedidoById(int id)
        {

        }
        public bool AlterarPedidoById(int id)
        {

        }
        public bool RemoverPedidoById(int id)
        {

        }

    }


}