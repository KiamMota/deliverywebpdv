using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Kel
{
    [Table("PedidoItens")]
    public class PedidoItem
    {
        [Key]
        public int PedidoItensId { get; set; }

        public int PedidoCabId { get; set; }

        [ForeignKey(nameof(PedidoItensId))]
        public virtual PedidoCab PedidoCab { get; set; }

        public int ProdutoId { get; set; }

        [ForeignKey(nameof(ProdutoId))]
        public virtual Produto Produto { get; set; }

        public decimal Qtd { get; set; }
    }
}
