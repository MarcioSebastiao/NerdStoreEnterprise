using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSE.WebAPI.Core.Controllers;

namespace NSE.Pedidos.Controllers
{
    public class PedidoController : MainController
    {
        [HttpGet("Pedido/test")]
        [Authorize]
        public ActionResult Index()
        {
            return CustomResponse("Swagger ok - JWT ok");
        }
    }
}
