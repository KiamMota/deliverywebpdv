namespace Domain.Entities.Helpers
{
    public class MonetarioHelper
    {
        public static bool Validar(decimal valor)
        {
            if (valor <= 0) throw new Exception("O valor é inseguro, selecione outro");
            return true;
        }




    }
}
