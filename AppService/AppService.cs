using Contracts.Request;
using Contracts.Response;
using Domain.Core.Validation;
using AppService.Interfaces;
using CrossCutting.Log;

namespace AppService
{
    public class ProcessPedido : IProcessPedido
    {
        private Log _log = new();
        private PedidoValidation _validation = new PedidoValidation();
        
        public int SalvarPedido(PedidoRequest pedido)
        {
            if (pedido == null) throw new ArgumentNullException("pedido é nulo!");
            if (!_validation.ValidarNome(pedido.nomePedido)) throw new Exception("NOME DO PEDIDO INVÁLIDO");
            return 0;
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