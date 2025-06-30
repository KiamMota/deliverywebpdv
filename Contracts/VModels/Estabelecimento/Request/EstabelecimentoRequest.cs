using System.ComponentModel.DataAnnotations;

namespace Contracts.VModels.ContractsEstabelecimento.Request
{
    public class EstabelecimentoRequest
    {
        [Required]
        public string nome { get; set; } = "";
        [Required]
        public string local { get; set; } = "";
        [Required]
        public IList<string> categorias { get; set; } = new string[0];
        [Required]
        public string descricao { get; set; } = "";
    }
}
