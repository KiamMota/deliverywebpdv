using Domain.Core.Entities.Base;


namespace Domain.Core.Entities.Interfaces
{
    public interface IEstabelecimento : IEntity
    {
        public int EstabelecimentoId { get; set; }
        public string EstabelecimentoNome { get; set; }
        public string EstabelecimentoLocal { get; set; }
        public IList<string> EstabelecimentoCategorias { get; set; }
        public string EstabelecimentoDescricao { get; set; }
    }
}
