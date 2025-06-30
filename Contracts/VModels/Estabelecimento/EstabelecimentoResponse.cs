using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Contracts.VModels.Estabelecimento
{
    public class EstabelecimentoResponse
    {
        public long id { get; set; }
        public string nome { get; set; } = "";
        public string local { get; set; } = "";
        public IList<string> categorias { get; set; } = new string[1];
        public string descricao { get; set; } = "";
    }
}
