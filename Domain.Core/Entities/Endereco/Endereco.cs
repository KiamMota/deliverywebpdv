using Domain.Core.Entities.Interfaces;
using Domain.Core.Entities.Endereco.Vo;

namespace Domain.Core.Entities.Endereco
{
    public sealed class Endereco : IEntity<long>
    {
        public long Id { get; private set; }
        public Rua Rua { get; private set; }
        public Bairro Bairro { get; private set; }
        public Estado Estado { get; private set; }
        public Cidade Cidade { get; private set; }
        public short Numero { get ; private set; }
        public Endereco(string rua, string bairro, string estado, string cidade, int numero)
        {
            Rua = new Rua(rua);
            Bairro = new Bairro(bairro);
            Estado = new Estado(estado);
            Cidade = new Cidade(cidade);
        }
    }
}
