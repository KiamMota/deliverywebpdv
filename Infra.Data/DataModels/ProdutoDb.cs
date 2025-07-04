using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infra.Data.DataModels
{
    [Table("produto")]
    public class ProdutoDb
    {
        [Key] public long Id { get; set; }    
        [Column("Nome")] public string Nome { get; set; }
        [Column("Preco")] public decimal Preco { get; set; }
        [Column("Disponivel")] public bool Disponivel { get; set; }
    }
}
