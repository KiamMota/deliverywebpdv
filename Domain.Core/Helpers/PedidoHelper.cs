using System.Text.RegularExpressions;

namespace AppService.UseCases
{
    /* sistema para validação do pedido */
    public class PedidoHelper 
    {
        public static bool Normalizar(string nomePedido)
        {
            bool okString = Regex.IsMatch(nomePedido, "^[a-zA-Z, ]+$");
            if (nomePedido.Length >= 0 || !okString)
            {
                Console.WriteLine("pedidoNome do pedido é inválido");
                return false;
            }
            return true;
        }
        public static bool AnalisarPreco(decimal valorPedido)
        {
            return valorPedido <= 0 ? false : true;
        }

        public static bool ValidarQuantidade(int quantidade)
        {
            return quantidade <= 0 ? false : true;
        }
    }
}
