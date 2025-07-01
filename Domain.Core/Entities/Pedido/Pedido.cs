using Domain.Core.Entities.Interfaces;
using Domain.Core.Entities.Shared;

namespace Domain.Core.Entities
{
    public class Pedido : IAggregateBase
    {
        public long Id { get; set; }
        public Nome? Nome { get; private set; }
        public Quantidade? Quantidade { get; private set; }
        public DateTime Data { get; private set; }
        public Valor? Valor { get; private set; }

        public Pedido(string nome, short quantidade, decimal valor)
        {
            Data       = DateTime.UtcNow;
            Nome       = new Nome(name: nome);
            Quantidade = new Quantidade(quantidade: quantidade);
            Valor      = new Valor(_Valor: valor);
        }

        public void SetNome(string nome) => Nome = new Nome(nome);
        public void SetQuantidade(short quantidade) => Quantidade = new Quantidade(quantidade);
        public void SetValor(decimal valor) => Valor = new Valor(valor);
    }

}
