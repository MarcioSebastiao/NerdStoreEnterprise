using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.Models;
using NSE.WebApp.Services;
using System.Threading.Tasks;

namespace NSE.WebApp.Extensions
{
    public class CarrinhoViewComponent : ViewComponent
    {
        private readonly ICarrinhoService _carrinhoService;

        public CarrinhoViewComponent(ICarrinhoService carrinhoService)
        {
            _carrinhoService = carrinhoService;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            return View(await _carrinhoService.ObterCarrinho() ?? new CarrinhoViewModel());
        }

    }
}
