using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.DataModels
{
    [Table("endereco")]
    public class EnderecoDb
    {
        [Key] public long Id { get; set; }
        [Column("Rua")] public string Rua { get; set; }
        [Column("Estado")] public string Estado { get; set; }
        [Column("Bairro")] public string Bairro { get; set; }
        [Column("Cidade")] public string Cidade { get; set; }
        [Column("Numero")]public short Numero { get; set; }
    }
}
