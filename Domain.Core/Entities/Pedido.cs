using Domain.Core.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Entities
{
    public class Pedido : IPedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]

        public string nomePedido { get; set; }
        [Required]
        public decimal valorPedido { get; set; }
        [Required]
        [Range(1, 99)]
        public int quantidadePedido { get; set; }
        public Pedido() => nomePedido = ""; /* para iniciar a string */
    }
}
