namespace Contracts.RequestModels
{
    public class EnderecoRequest
    {
        public string Rua {  get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public short Numero { get; set; }
    }
}
