namespace Contracts.ResponseModels
{
    public class Cliente
    {
        public long Id { get; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
