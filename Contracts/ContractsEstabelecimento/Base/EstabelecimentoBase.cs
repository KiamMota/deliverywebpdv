using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Contracts.ContractsEstabelecimento.Base
{
    public class EstabelecimentoBase : IEstabelecimento
    {

        public int id { get; set; }
        public string nome { get; set; } = "Sem Nome";
        public string local { get; set; } = "Sem Nome";
        public IList<string> categorias { get; set; } = new string[0];
        public string descricao { get; set; } = "Sem Nome";
    }
}
