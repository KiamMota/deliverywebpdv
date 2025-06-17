using System.ComponentModel;

namespace Domain.Core.Interfaces.Entities
{
    public interface IUser
    {
        int     Id { get; }
        int     Prop { get; set; }
        string Email { get; set; }
        string  Nome { get; set; }
        string  Password { get; set; }
    }
}
