
namespace Domain.Core.Entities.Interfaces
{
    public interface IEstabelecimento
    {
        public int estabId { get; set; }
        public string estabNome { get; set; }
        public string estabLocal { get; set; }
        public IList<string> estabCategorias { get; set; } 
        public string estabDescricao { get; set; }
    }
}
