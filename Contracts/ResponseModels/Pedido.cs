namespace Contracts.ResponseModels
{
    public class Pedido
    {
        public long Id { get; }
        public string NomePedido { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
    }
}
