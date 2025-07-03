using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Core.DataModels
{
    [Table("pedido")]
    public class Pedido
    {
        [Key] public int Id { get; set; }
        [ForeignKey("ClienteId")]public int ClienteId { get; set; }
        [ForeignKey("ProdutoId")] public int ProdutoId { get; set; }

    }
}
