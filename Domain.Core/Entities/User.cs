using Domain.Core.Interfaces.Entities;

using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities
{
    public class User : IUser
    {
        public int Id       { get; set; }
        public int Prop     { get; set; }
        public string Nome  { get; set; } = "";
        public string Password  { get; set; } = "";
    }
}
