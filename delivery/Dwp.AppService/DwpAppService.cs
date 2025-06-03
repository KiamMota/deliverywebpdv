using System.ComponentModel.DataAnnotations;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Core.Entity;
using Delivery.Web.Pdv.Helper;
using Delivery.Web.Pdv.Repository;
using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.AspNetCore.Mvc;




namespace Delivery.Web.Pdv.AppService
{ 
    public interface IAppService
    {
        public void CreatePedido(PedidoDto pedidodto);
        public void GetPedido(int idPedido);
        public void DeletePedido(int idPedido);
    }

    public class AppService : IAppService
    {
        public void CreatePedido(PedidoDto pedidodto)
        {
            Pedido pedido = DwpHelper.ParaPedido(pedidodto);
        }
        public void GetPedido(int idPedido)
        {

        }
        public void DeletePedido(int idPedido);


    }







}