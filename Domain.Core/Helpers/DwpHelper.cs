using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Delivery.Web.Pdv.Helper
{
    public class DwpHelper
    {
        public static bool No<T>(T obj)
        {
            if (obj == null) return true;
            return EqualityComparer<T>.Default.Equals(obj, default(T));
        }

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
                case false:
                    return BigBoolean.False;   
            }
        }
        
    }
}
