using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Interfaces.Entities
{
    public interface IPedido
    {
        int Id { get; set; }
        string nomePedido { get; set; }
        decimal valorPedido { get; set; }
        int quantidadePedido { get; set; }
    }
}
