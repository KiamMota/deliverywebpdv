using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Kel
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string CodBarra { get; set; }
        public string Nome { get; set; } = "";
        public decimal PrecoVenda { get; set; }

    }
}
