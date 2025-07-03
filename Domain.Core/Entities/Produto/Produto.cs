using Domain.Core.Entities.Interfaces;

using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Core.Entities.Produto
{
    [Table("produto")]
    public class Produto : IEntity<Guid>
    {
        public Guid Id { get; private set; }
        public Domain.Core.Entities.Produto.Vo.Nome Nome { get; private set; }
        public Vo.Preco Preco{ get; private set; }
        public Vo.EhDisponivel Disponivel { get; private set; }

        public Produto(string Nome, decimal Preco, bool Disponivel)
        {
            this.Nome = new(Nome);
            this.Preco = new(Preco);
            this.Disponivel = new(Disponivel);
        }
    }
}
