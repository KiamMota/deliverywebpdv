using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Interfaces.Pedido
{
    public interface IPedidoValidation
    {
        bool ValidarNome(string nomePedido);
        bool AnalisarPreco(decimal valorPedido);
        bool ValidarQuantidade(int quantidade);
    }
}
