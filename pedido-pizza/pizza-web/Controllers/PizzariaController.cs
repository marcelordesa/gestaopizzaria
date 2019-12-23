using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pizza_domains.Contracts.Services;
using pizza_models;
using pizza_serviceFactory;
using pizza_services;

namespace pizza_web.Controllers
{
    [ApiController]
    public class PizzariaController : ControllerBase
    {
        private IService service = ServiceFactory.GetInstanciaServico<PizzaService>();

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<RetornoPedidoModel> Post(PedidoPizzaModel pedido)
        {
            RetornoPedidoModel retorno = new RetornoPedidoModel();
            try
            {
                retorno = (RetornoPedidoModel)service.GetPedido(pedido);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return retorno;
        }
    }
}