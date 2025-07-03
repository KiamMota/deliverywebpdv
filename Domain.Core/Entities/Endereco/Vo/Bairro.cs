using Domain.Entities.Helpers;

namespace Domain.Core.Entities.Endereco.Vo
{
    public class Bairro
    {
        public string Nome { get; set; }

        public Bairro(string bairro)
        {
            if(NomeHelper.Verificar(bairro)) Nome = bairro;
        }

    }
}
