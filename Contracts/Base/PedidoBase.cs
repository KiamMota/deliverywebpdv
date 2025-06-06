using Domain.Core.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Base
{
    public class PedidoBase : IPedido
    {
        public string nomePedido { get; set; } = "";
        public decimal valorPedido { get ; set ; }
        public int quantidadePedido { get ; set ; }
    }
}
