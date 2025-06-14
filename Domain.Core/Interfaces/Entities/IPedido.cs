﻿namespace Domain.Core.Pedido.Interfaces
{
    public interface IPedido
    {
        DateTime data { get; set; }
        int id { get; set; }
        string nome { get; set; }
        decimal valor { get; set; }
        int quantidade { get; set; }
    }
}
