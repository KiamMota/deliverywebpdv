using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DataModels
{
    [Table("endereco")]
    public class Endereco
    {
        [Key] public long Id { get; set; }
        [Column("Rua")] public string Rua { get; set; }
        [Column("Estado")] public string Estado { get; set; }
        [Column("Bairro")] public string Bairro { get; set; }
        [Column("Numero")]public short Numero { get; set; }
    }
}
