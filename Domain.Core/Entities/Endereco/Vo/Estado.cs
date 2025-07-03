using Domain.Entities.Helpers;

namespace Domain.Core.Entities.Endereco.Vo
{
    public class Estado
    {
        public string Nome { get; set; }
        public Estado(string estado)
        {
            if (NomeHelper.Verificar(estado)) Nome = estado; 
        }
    }
}
