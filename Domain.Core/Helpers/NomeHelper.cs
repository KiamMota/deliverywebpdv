using System.Text.RegularExpressions;

namespace Domain.Entities.Helpers
{
    /* sistema para validação do pedido */
    public class NomeHelper
    {
        public static bool Verificar(string nome)
        {
            if (char.IsLower(nome[0])) throw new Exception("A primeira letra deve ser maiúscula!");
            if (nome.Length <= 3) throw new Exception("O Nome deve ter pelo menos mais de 4 caracteres!");
            return true;
        }
    }
}
