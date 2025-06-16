using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Contracts.ContractsEstabelecimento.Base
{
    public class EstabelecimentoBase : IEstabelecimento
    {
        public int estabId { get; set; }
        public string estabNome { get; set; } = "";
        public string estabLocal { get; set; } = "";
        public IList<string> estabCategorias { get; set; } = new string[0];
        public string estabDescricao { get; set; } = "";
    }
}
