using Contracts.ContractsEstabelecimento.Base;
using System.ComponentModel.DataAnnotations;

namespace Contracts.ContractsEstabelecimento.Request
{
    public class EstabeleimentoRequest : EstabelecimentoBase
    {
        [Required] public string nome { get; set; } = "Sem Nome";
        [Required] public string local { get; set; } = "Sem Nome";
        [Required] public IList<string> categorias { get; set; } = new string[0];
        [Required] public string descricao { get; set; } = "Sem Nome";
    }
}
