namespace Contracts.VModels
{
    public class ProdutoRequest
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }
    }
}
