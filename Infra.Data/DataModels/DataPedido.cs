using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infra.Data.DataModels
{
    [Table("pedido")]
    public class DataPedido
    {
        [Key] public long Id { get; set; }
        [ForeignKey("ClienteId")]public long ClienteId { get; set; }
        [ForeignKey("ProdutoId")] public long ProdutoId { get; set; }

    }
}
