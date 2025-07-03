using Domain.Entities.Helpers;

namespace Domain.Core.Entities.Cliente.Vo
{
    public class Email
    {
        public string email { get; private set; }
        public Email(string email)
        {
            if(EmailHelper.EmailValido(email)) this.email = email;
        }
    }
}
