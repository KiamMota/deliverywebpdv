using Domain.Core.Entities.Interfaces;

namespace Domain.Core.Entities.Cliente
{
    public class Cliente : IEntity<long>
    {
        public long Id { get; private set; }
        public Vo.Nome Nome { get; private set; }
        public Vo.Email Email { get; private set; }
        public Vo.CPF CPF { get; private set; }
        public long EnderecoId { get; private set; }
        public string Senha { get; private set; }

        public Cliente(string nome, long EnderecoId, string email, string cpf, string senha)
        {
            Id = Guid.NewGuid();
            Email = new Vo.Email(email);
            CPF = new Vo.CPF(cpf);
            Nome = new Vo.Nome(nome);
            this.EnderecoId = EnderecoId;
            Senha = senha;
        }
    }
}
