namespace Domain.Core.Interfaces
{
    internal interface IPedidoValidation
    {
            bool ValidarNome(string nomePedido);
            bool AnalisarPreco(decimal valorPedido);
            bool ValidarQuantidade(int quantidade);
    }
}
