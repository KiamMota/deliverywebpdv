namespace Domain.Core.Entities.Pedido
{
    public class Nome
    {
        public string _Name { get; private set; }   
        public Nome(string name)
        {
            if(string.IsNullOrEmpty(name)) new ArgumentNullException("name é nulo!");
            _Name = name;
        }
    }
    public class Quantidade
    {
        public short _Quantidade { get; private set;  }
        public Quantidade(short quantidade)
        {
            if (quantidade <= 0 || quantidade >= 100) throw new ArgumentOutOfRangeException("A quantidade não pode ser menor que 0 ou igual! ");
            _Quantidade = quantidade;
        }
    }

    public class Valor
    {
        public decimal _Valor { get; private set; }
        public Valor(decimal _Valor)
        {
            if (_Valor <= 0) throw new ArgumentException("Valor não pode ser nulo!");
            this._Valor = _Valor;
        }
       
    }


}
