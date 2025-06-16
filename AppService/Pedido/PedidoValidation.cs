using AppService.Interfaces.Pedido;
using System.Text.RegularExpressions;

namespace AppService
{
    /* sistema para validação do pedido */
    public class PedidoValidation : IPedidoValidation
    {
        public bool ValidarNome(string nomePedido)
        {
            bool okString = Regex.IsMatch(nomePedido, "^[a-zA-Z, ]+$");
            if (nomePedido.Length >= 0 || !okString)
            {
                Console.WriteLine("pedidoNome do pedido é inválido");
                return false;
            }
            return true;
        }
        public bool AnalisarPreco(decimal valorPedido)
        {
            return valorPedido <= 0 ? false : true;
        }

        public bool ValidarQuantidade(int quantidade)
        {
            return quantidade <= 0 ? false : true;
        }
    }
}
