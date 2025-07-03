using Domain.Entities.Helpers;

namespace Domain.Core.Entities.Cliente.Vo
{
    public class Nome
    {
        public string nome { get; set; }
        public Nome(string nome)
        {
            if (NomeHelper.Verificar(nome)) this.nome = nome;
        }
    }
}
