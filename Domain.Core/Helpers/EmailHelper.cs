using System.Text.RegularExpressions;

namespace Domain.Entities.Helpers
{
    /* sistema para validação do pedido */
    public class EmailHelper
    {
        public static bool EmailValido(string email)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regex.IsMatch(email))
            {
                throw new Exception("O Email é inválido sintaticamente");
            }
            return true;
            
        }
    }
}
