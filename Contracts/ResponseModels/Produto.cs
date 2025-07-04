namespace Contracts.ResponseModels
{
    public class ProdutoResponse
    {
        public long Id { get; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }
    }
}
