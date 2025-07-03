namespace Contracts.ResponseModels
{
    public class Produto
    {
        public long Id { get; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }
    }
}
