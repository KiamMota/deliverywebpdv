using Delivery.Web.Pdv.AppService;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Core.Entity;
using System.ComponentModel.DataAnnotations;

namespace Delivery.Web.Pdv.Helper
{
    public class DwpHelper
    {
        public enum BigBoolean : short
        {
            Error = -1,
            False, True
        }
        public bool Normalizar(Pedido dto)
        {
            if (DwpHelper.ObjIsValidAll(dto) == DwpHelper.BigBoolean.False) return false;
            if (dto.valorPedido >= 100)
                DwpHelper.AplicarDesconto(dto);
            if (char.IsLower(dto.nomePedido[0]))
                dto.nomePedido = char.ToUpper(dto.nomePedido[0]) + dto.nomePedido.Substring(1);
            return true;
        }

        public static decimal AplicarDesconto(Pedido dto, int porcentagem = 20)
        {
            decimal desconto = dto.valorPedido * (porcentagem / 100m);
            return dto.valorPedido - desconto;
        }

        public static BigBoolean ObjIsValidAll(Object obj)
        {
            var context = new ValidationContext(obj);            
            List<ValidationResult> validation = new();
            bool isValid = Validator.TryValidateObject(obj, context, validation, true);
            if (typeof(Object) != typeof(Object))
            {
                Console.WriteLine("Tipo não é object!");
                return BigBoolean.Error;
            }
         
            switch (isValid)
            {
                case true:
                    return BigBoolean.True;
                    break;
                case false:
                    return BigBoolean.False;
                default:
                    return BigBoolean.Error;
                    break;
            }
        }
        
    }
}
