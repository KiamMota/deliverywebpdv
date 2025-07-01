using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Kel
{
    [Table("pedidocab")]
    public class Venda
    {
        [Key]
        public int PedidoCabId { get; set; }

        public DateTime DataHoraVenda { get; set; }
        public int ClienteId { get; set; }

        [ForeignKey(nameof(ClienteId))]
        public virtual Cliente Cliente { get; set; }

        public virtual IList<PedidoItem> Itens { get; set; }

    }
}
