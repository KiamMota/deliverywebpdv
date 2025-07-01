using Domain.Core.Entities;
using Domain.Core.Entities.Interfaces;
using Domain.Core.Kel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Agreggates
{
    public class Pedido : IAggregateRoot
    {
        public Pedido(ClienteVO cliente)
        {
            Cliente = cliente;
        }

        public Guid Id { get; private set; } = Guid.NewGuid();

        public ClienteVO Cliente { get; private set; }
        public List<ItemPedido> ItensPedido { get; private set; } = new();


        public void AdicionarItemPedido(ItemPedido item)
        {
            this.ItensPedido.Add(item);
        }

    }

    public class ItemPedido : IMyAggregate
    {
        public string CodBarra { get; set; }
        public decimal QtdVendida { get; set; }
    }
}
