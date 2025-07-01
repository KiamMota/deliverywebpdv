using Domain.Core.Entities.Produto.Vo;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Core.Entities.Produto
{
    [Table("produto")]
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public bool Disponivel { get; private set; }

        public Produto(string Nome, decimal Preco, string Disponivel, Estado estado) {
            this.Nome = Nome;
            this.Preco = Preco;
        }



    }
}
