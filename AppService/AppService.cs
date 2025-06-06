using Contracts.Request;
using Contracts.Response;
using Domain.Core.Validation;
using AppService.Interfaces;

namespace AppService
{
    public class ProcessPedido : IProcessPedido
    {
        private PedidoValidation _validation = new PedidoValidation();
        PedidoResponse SalvarPedido(PedidoRequest pedido)
        {

        }
        PedidoResponse PegarPedidoById(int id)
        {

        }
        PedidoResponse AlterarPedidoById(int id)
        {



        }
        bool RemoverPedidoById(int id)
        {



        }

    }


}