
namespace Domain.Core.Estabelecimento.Interfaces
{
    public interface IEstabelecimento
    {
        public string nome { get; set; }
        public string local { get; set; }
        public IList<string> categorias { get; set; } 
        public string descricao { get; set; }
    }
}
