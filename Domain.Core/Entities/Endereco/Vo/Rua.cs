using Domain.Entities.Helpers;

namespace Domain.Core.Entities.Endereco.Vo
{
    public class Rua
    {
        public string Nome { get; set; }
        public Rua(string rua)
        {
            if(NomeHelper.Verificar(rua)) Nome = rua;
        }
    }
}
