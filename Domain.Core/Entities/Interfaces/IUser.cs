using Domain.Core.Entities.Base;
using System.ComponentModel;

namespace Domain.Core.Entities.Interfaces
{
    public interface IUser : IEntity
    {
        int Id { get; set; }
        int Prop { get; set; }
        string Nome { get; set; }
        string Password { get; set; }
    }
}
