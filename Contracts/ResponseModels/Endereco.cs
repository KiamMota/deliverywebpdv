namespace Contracts.ResponseModels
{
    public class Endereco
    {
        public long Id { get; }
        public string Rua { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public short Numero { get; set; }
    }
}
