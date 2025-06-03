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
