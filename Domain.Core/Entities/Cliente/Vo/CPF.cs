namespace Domain.Core.Entities.Cliente.Vo
{
    public class CPF
    {
        public string cpf { get; set; }
        public CPF(string cpf)
        {
            if (cpf.Length < 11 || cpf.Length > 11) throw new ArgumentException("Cpf é inválido!");
            this.cpf = cpf;
        }
    }
}
