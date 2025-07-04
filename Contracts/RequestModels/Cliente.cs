using System.Reflection.Metadata.Ecma335;

namespace Contracts.RequestModels
{
    public class ClienteRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public long EnderecoId { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
