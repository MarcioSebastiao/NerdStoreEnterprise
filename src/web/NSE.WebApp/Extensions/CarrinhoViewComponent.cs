using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.Models;
using NSE.WebApp.Services;
using System.Threading.Tasks;

namespace NSE.WebApp.Extensions
{
    public class CarrinhoViewComponent : ViewComponent
    {
        private readonly IComprasBffService _comprasBffService;

        public CarrinhoViewComponent(IComprasBffService carrinhoService)
        {
            _comprasBffService = carrinhoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _comprasBffService.ObterQuantidadeCarrinho());
        }

    }
}
