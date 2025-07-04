using Domain.Entities.Helpers;

namespace Domain.Core.Entities.Endereco.Vo
{
    public class Cidade
    {
        public string Nome { get; private set; }
        public Cidade(string cidade)
        {
            if (NomeHelper.Verificar(cidade))
            {
                this.Nome = cidade;
            }
            throw new ArgumentException("Nome da cidade inválido.");
        }
    }
}
