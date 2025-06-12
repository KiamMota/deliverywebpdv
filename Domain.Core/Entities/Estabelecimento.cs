using Domain.Core.Entities.Interfaces;

namespace Domain.Core.Entities
{
    public class Estabelecimento : IEstabelecimento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string local { get; set; }
        public IList<string> categorias { get; set; }
        public string descricao { get; set; }
    }
}
