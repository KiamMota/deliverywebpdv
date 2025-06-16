using Domain.Core.Interfaces.Entities;

using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities
{
    public class User : IUser
    {
        [Key]
        public int Id       { get; set; }
        [Required]
        public int Prop     { get; set; }
        [Required]
        public string Nome  { get; set; } = "";
        [Required]
        [MinLength(8, ErrorMessage = "Senha deve ter no mínimo 8 caracteres!")]
        [MaxLength(255)]
        public string Password  { get; set; } = "";
    }
}
