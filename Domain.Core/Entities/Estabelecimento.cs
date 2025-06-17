using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities
{
    public class Estabelecimento : IEstabelecimento
    {
        [Key]
        public int estabId { get; set; }
        [Required]
        public string estabNome { get; set; }
        [Required]
        public string estabLocal { get; set; }
        [Required]
        
        public IList<string> estabCategorias { get; set; }
        [Required]
        public string estabDescricao { get; set; }
    }
}
