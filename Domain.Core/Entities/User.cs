using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entities
{
    public class User : IEntityBase
    {
        public long Id          { get; set; }
        public string Name      { get; set; } = "";
        public int Prop         { get; set; }
        public string Password  { get; set; } = "";
    }
}
