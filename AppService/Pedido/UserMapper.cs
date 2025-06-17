using Contracts.User;

namespace AppService.Pedido
{
    public class UserMapper
    {
        public static Domain.Core.Entities.User FromRequest(UserRequest request)
        {
            return new Domain.Core.Entities.User 
            {
                Nome = request.Nome,
                Password = request.Senha,
                Prop     = request.Prop,
            };
        }

        public static UserResponse UserToReponse(Domain.Core.Entities.User User)
        {
            return new UserResponse()
            {
                Prop  = User.Prop,
                Senha = User.Password,
                Nome  = User.Nome,
                Id    = User.Id,
            };
        }

    }
}
