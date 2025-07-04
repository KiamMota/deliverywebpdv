using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infra.Data.DataModels
{
    [Table("cliente")]
    public class ClienteDb
    {
        [Key] public long Id { get; set; }
        [ForeignKey("EnderecoId")] public long EnderecoId { get; set; }
        [Column("Nome")] public string Nome { get; set; }
        [Column("Email")] public string Email { get; set; }
        [Column("CPF")] public string CPF { get; set; }
        [Column("Senha")] public string Senha { get; set; }
    }
}
