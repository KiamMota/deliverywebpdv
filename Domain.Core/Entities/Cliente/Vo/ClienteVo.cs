namespace Domain.Core.Entities.Cliente.Vo
{
    public class Nome
    {
        public string nome { get; private set; }
        public Nome(string nome) {
            this.nome = nome;
        }   
    }
}
