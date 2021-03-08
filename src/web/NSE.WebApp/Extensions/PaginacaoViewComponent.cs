using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.Models;

namespace NSE.WebApp.Extensions
{
    public class PaginacaoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPagedList modeloPaginado)
        {
            return View(modeloPaginado);
        }
    }
}
