using System.ComponentModel.DataAnnotations;

namespace Contracts.VModels.Estabelecimento
{
    public class EstabelecimentoRequest
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Local { get; set; } = "";
        [Required]
        public IList<string> Categorias { get; set; } = new string[0];
        [Required]
        public string Descricao { get; set; } = "";
    }
}
