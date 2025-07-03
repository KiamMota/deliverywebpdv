using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Core.DataModels
{
    [Table("produto")]
    public class Produto
    {
        [Column("Nome")] public string Nome { get; set; }
        [Column("Preco")] public decimal Precio { get; set; }
        [Column("Disponivel")] public decimal Disponivel { get; set; }
    }
}
