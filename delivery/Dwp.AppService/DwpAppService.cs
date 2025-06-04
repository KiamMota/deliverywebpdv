using System.ComponentModel.DataAnnotations;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Core.Entity;
using Delivery.Web.Pdv.Helper;
using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;




namespace Delivery.Web.Pdv.AppService
{ 
    public interface IAppService
    {
        public bool CriarPedido(PedidoDto dto);
        public bool EntregarPedido(PedidoDto dto);
    }

    public class AppService : IAppService
    {
        private IValidacao _validation = new Validacao();        
        public bool CriarPedido(PedidoDto dto)
        {
            var pedidoCriar = _validation.ToPedido(dto);
            /* todo: sistema do banco*/
            return (dto is null) ? false : true;

        }

        public bool EntregarPedido(PedidoDto dto)
        {
            var pedidoEntregar = _validation.ToPedido(dto);
            return (dto is null) ? false : true;

        }


    }
}