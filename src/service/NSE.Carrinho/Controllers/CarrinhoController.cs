using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSE.WebAPI.Core.Controllers;

namespace NSE.Carrinho.Controllers
{
    [Authorize]
    public class CarrinhoController : MainController
    {
        [HttpGet("carrinho/test")]
        public ActionResult Index()
        {
            return CustomResponse("Swagger ok - JWT ok");
        }
    }
}
