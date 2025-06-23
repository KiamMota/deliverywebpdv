using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities
{
    public class Estabelecimento : IEstabelecimento
    {
        [Key]
        public int EstabelecimentoId { get; set; }
        [Required]
        public string EstabelecimentoNome { get; set; }
        [Required]
        public string EstabelecimentoLocal { get; set; }
        [Required]
        
        public IList<string> EstabelecimentoCategorias { get; set; }
        [Required]
        public string EstabelecimentoDescricao { get; set; }
    }
}
