using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities
{
    public class Estabelecimento : IEstabelecimento
    {
        [Key]
        public int estabId { get; set; }
        public string estabNome { get; set; }
        public string estabLocal { get; set; }
        public IList<string> estabCategorias { get; set; }
        public string estabDescricao { get; set; }
    }
}
