using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Helper;

namespace Delivery.Web.Pdv.Core
{
    public class DwpCore
    {
        public bool Validar(PedidoDto pedido)
        {
            if (DwpHelper.ObjIsValidAll(pedido) == DwpHelper.BigBoolean.False) return false;
            if (pedido.valorPedido >= 100)
                DwpCore.AplicarDesconto(pedido);
            if (char.IsLower(pedido.nomePedido[0]))
                pedido.nomePedido = char.ToUpper(pedido.nomePedido[0]) + pedido.nomePedido.Substring(1);
            return true;
        }

        public static decimal AplicarDesconto(PedidoDto dto, int porcentagem = 20)
        {       
            decimal desconto = dto.valorPedido * (porcentagem / 100m);
            return dto.valorPedido - desconto;
        }

    }
}
