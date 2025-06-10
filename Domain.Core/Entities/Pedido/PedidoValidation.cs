using Domain.Core.Interfaces;
using Domain.Core.Entities;
using System.Text.RegularExpressions;

namespace Domain.Core.Entities.Pedido
{
    /* sistema para validação do pedido */
    public class PedidoValidation : IPedidoValidation
    {
        public bool ValidarNome(string nomePedido)
        {
            bool okString = Regex.IsMatch(nomePedido, "^[a-zA-Z, ]+$");
            if (nomePedido.Length >= 0 || !okString)
            {
                Console.WriteLine("nome do pedido é inválido");
                nomePedido = "Inválido";
                return false;
            }
            else return true;
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
