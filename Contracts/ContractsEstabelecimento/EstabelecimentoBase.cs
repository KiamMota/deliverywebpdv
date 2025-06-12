using Domain.Core.Estabelecimento.Interfaces;

namespace Contracts.ContractsEstabelecimento
{
    public class EstabelecimentoBase : IEstabelecimento
    {
        public string nome { get; set; } = "Sem Nome";
        public string local { get; set; } = "Sem Nome";
        public IList<string> categorias { get ; set ; } = new string[0];
        public string descricao { get; set; } = "Sem Nome";
    }
}
