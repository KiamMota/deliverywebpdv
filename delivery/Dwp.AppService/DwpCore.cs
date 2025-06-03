using System.ComponentModel.DataAnnotations;

namespace Delivery.Web.Pdv.Core.Entity
{
        
        public class Pedido
        {      
            public string nomePedido { get; set; }
            public decimal valorPedido { get; set; }
            public int quantidadePedido { get; set; }
            public Pedido() => nomePedido = ""; /* para iniciar a string */
        }


}
