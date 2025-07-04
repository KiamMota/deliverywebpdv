using Domain.Entities.Helpers;

namespace Domain.Core.Entities.Produto.Vo
{
    public class Preco
    {
        public decimal preco { get; set; }
        public Preco(decimal preco)
        {
            if (MonetarioHelper.Validar(preco)) this.preco = preco;
        }


    }
}
