using System.ComponentModel;

namespace Domain.Core.Entities.Interfaces
{
    public interface IUser
    {
        int Id { get; }
        int Prop { get; set; }
        string Nome { get; set; }
        string Password { get; set; }
    }
}
