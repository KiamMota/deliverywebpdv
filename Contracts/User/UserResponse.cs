using Domain.Core.Entities.Interfaces;
namespace Contracts.User
{
    public class UserResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Prop { get; set; }
        public string Password { get; set; }



    }
}
