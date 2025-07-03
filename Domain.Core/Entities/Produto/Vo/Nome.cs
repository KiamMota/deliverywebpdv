using AppService.UseCases;

namespace Domain.Core.Entities.Produto.Vo
{
    public class Nome
    {
        public string nome { get; set; }
        public Nome(string nome)
        {
            if(NomeHelper.Verificar(nome)) this.nome = nome;
        }

    }
}
