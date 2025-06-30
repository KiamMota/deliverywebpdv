using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities
{
    public class Estabelecimento : IEntityBase
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Local { get; set; }
        [Required]
        
        public IList<string> Categorias { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
